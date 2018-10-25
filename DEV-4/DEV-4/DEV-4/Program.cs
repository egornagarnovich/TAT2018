using System;
using System.IO;

namespace DEV4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string pathToXml = args[0];
                string dataXml = File.ReadAllText(pathToXml);
                dataXml = dataXml.Replace(" ", "");
                dataXml = dataXml.Replace("\n", "");
                XmlParser parser = new XmlParser();
                string result = parser.GetXmlString(dataXml);
                //Console.WriteLine(result);
            }
            catch(Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}