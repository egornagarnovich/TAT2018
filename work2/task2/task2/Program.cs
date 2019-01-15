using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string inputString = args[0];
                if (inputString.Length == 0)
                {
                    throw new Exception("Incorrect of argument");
                }
                LinkDetector detector = new LinkDetector();
                Console.WriteLine(detector.GetLink(ref inputString));
            }
            catch(Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}
