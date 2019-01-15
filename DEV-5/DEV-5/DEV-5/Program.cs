using System;
namespace DEV5
{
    /// <summary>
    /// Main class.
    /// Contains all methods for performing basic functions.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        public static void Main()
        {
            DatabaseBuilder databaseBuilder = new DatabaseBuilder();
            CarCreator carCreator = new CarCreator();
            Accountant accountant = new Accountant();
            do
            {
                try
                {
                    carCreator.Create();
                    databaseBuilder.Build();
                    Console.WriteLine("Press Esc to end input. Press Enter to continue input");
                }
                catch (Exception error)
                {
                    Console.WriteLine("Build error: " + error.Message);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            string inputCommand = Interviewer.GetObjInterviewer().AskCommand();
            if (inputCommand == "exit")
                Environment.Exit(0);
            else
            {
                Console.WriteLine(accountant.GetResultOfQuery(inputCommand));
            }
        }
    }
}