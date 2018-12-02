using System;
using System.Collections.Generic;
namespace DEV8
{
    /// <summary>
    /// Class containing user interaction methods
    /// </summary>
    public class Interviewer
    {
        private List<string> trueCommands = new List<string> { "count types", "count all", "average price", "execute" };

        /// <summary>
        /// Asks the user command.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The user command.</returns>
        public string AskCommand()
        {
            Console.WriteLine("Enter command: ");
            string inputCommand = Console.ReadLine();
            if (!trueCommands.Contains(inputCommand))
            {
                Console.WriteLine("Sorry, Wrong command. Try again.");
                AskCommand();
            }
            return inputCommand;
        }
    }
}