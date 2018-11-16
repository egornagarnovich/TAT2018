using System;
using System.IO;

namespace DEV6
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
        /// <param name="args">The command-line arguments. Path to json or xml file.</param>
        public static void Main(string[] args)
        {
            FileConverter converter = new FileConverter();
            try
            {
                if (Path.GetExtension(args[0]) == ".json")
                {
                    string jsonString = File.ReadAllText(args[0]);
                    converter.ConvertToXml(jsonString);
                }
                else
                {
                    string xmlString = File.ReadAllText(args[0]);
                    converter.ConvertToJson(xmlString);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error:" + error.Message);
            }
        }
    }
}
