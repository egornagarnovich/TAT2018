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
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
	    try
	    {
		int number = int.Parse(args[0]);
               int newDigitalSystem = int.Parse(args[1]);
		if (newDigitalSystem < 2 || newDigitalSystem > 20)
		{
		    throw new Exception("Incorrect of argument.");
		}
		DigitalConverter converter = new DigitalConverter();
                string convertedNumber = converter.ConvertToDifferentDigitalSystems(number, newDigitalSystem);
                Console.WriteLine(convertedNumber);
	    }
	    catch (Exception error)
           {
                Console.WriteLine("Error: " + error.Message);
           }
        }
    }
}
