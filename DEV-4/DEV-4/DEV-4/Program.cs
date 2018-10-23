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
				string pathToXmlFile = args[0];
				XmlParser parser = new XmlSorter();
				string dataXml = File.ReadAllText(pathToXmlFile);
				string parsedXml = parser.ParseXml(ref dataXml);
                Console.WriteLine(parsedXml);
			}
			catch(Exception error)
			{
				Console.WriteLine("Error: " + error.Message);
			}
        }
    }
}
