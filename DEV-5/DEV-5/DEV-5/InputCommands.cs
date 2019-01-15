using System.Collections.Generic;
namespace DEV5
{
    /// <summary>
    /// Class contains a list of valid commands and methods for checking input commands.
    /// </summary>
    public class InputCommands
    {
        List<string> trueCommands = new List<string> {"count types", "count all", "average price", "exit"};
        DatabaseInformation databaseInformation = new DatabaseInformation();

        /// <summary>
        /// Checks the command.
        /// </summary>
        /// <returns><c>true</c>, if command was checked, <c>false</c> otherwise.</returns>
        /// <param name="command">User command.</param>
        public bool CheckCommand(string command)
        {
            foreach (string brand in databaseInformation.GetAllBrands())
            {
                if ( command == trueCommands[2] + " " + brand)
                {
                    return true;
                }
            }
            return trueCommands.Contains(command);
        }
    }
}