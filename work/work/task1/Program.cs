using System;

namespace task1
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
        /// <param name="args">Arbitrary string.</param>
        public static void Main(string[] args)
        {
            try
            {
                MaximumNumberOfMatches match = new MaximumNumberOfMatches();
                string inputString = args[0];
                if (inputString.Length < 2)
                {
                    throw new Exception("Incorrect of argument");
                }
                if (inputString.Length == 2)
                {
                    Console.WriteLine(inputString);
                }
                Console.WriteLine(match.GetMaximumNumberOfMatches(ref inputString));
            }
            catch(Exception error)
            {
                Console.WriteLine("Eror: " + error.Message);
            }
        }
    }
}
