using System;

namespace DEV9
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
            try
            {
                string logging = "logging";
                string password = "password";
                VkMessage message = new VkMessage();
                Console.WriteLine(message.GetUnreadMessage(ref logging, ref password));
            }
            catch(Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}