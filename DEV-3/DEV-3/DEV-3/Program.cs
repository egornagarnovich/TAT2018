using System;

namespace DEV3
{
    /// <summary>
    /// The Main class.
    /// Contains all methods for performing basic functions.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">Integer in decimal and the base of the new number system.</param>
        public static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(args[0]);
                int newNumberSystem = int.Parse(args[1]);
                int minRadix = 2;
                int maxRadix = 20;
                if (newNumberSystem < minRadix || newNumberSystem > maxRadix)
                {
                    throw new Exception("Argument is incorrect.");
                }
                NumberConverter converter = new NumberConverter();
                string convertedNumber = converter.ConvertToDifferentNumberSystems(number, newNumberSystem);
                if (number < 0)
                {
                    convertedNumber = string.Concat("-", convertedNumber);
                }
                Console.WriteLine(convertedNumber);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}