using System;

namespace task1
{
    class MainClass
    {
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
