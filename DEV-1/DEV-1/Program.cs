using System;

namespace DEV1
{
	/// <summary>
    /// The main Math class.
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
				if (args[0].Length == 0)
				{
					throw new Exception("Incorrect of argument");
				}
				string inputString = args[0];
                int maxLengthOfSequence = MaxNumberOfSequence.GetLengthOfSequence(inputString);
                Console.WriteLine(maxLengthOfSequence);
			}
			catch(Exception error)
			{
				Console.WriteLine("Error: " + error.Message);
			}
        }
    }
}