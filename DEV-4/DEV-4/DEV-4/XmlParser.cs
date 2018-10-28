using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace DEV4
{
    public class XmlParser
    {
        public string GetXmlString(string dataXml)
        {
            StringBuilder keysAndValuesString = new StringBuilder();
            StringBuilder nextParsedXmlLines = new StringBuilder();
            Dictionary<string, string> parsedXmlLines = new Dictionary<string, string>();
            for (int numberElement = 0; numberElement < dataXml.Length - 1; numberElement++)
            {
                if ( dataXml[numberElement] == '<' && dataXml[numberElement + 1] == '/')
                {
                    while ( dataXml[numberElement] != '>')
                    {
                        numberElement++;
                    }
                }
                if (dataXml[numberElement] == '<' && dataXml[numberElement + 1] != '/')
                {
                    KeyValuePair<string, int> keyAndNumberElement = GetKeys(dataXml, numberElement + 1);
                    numberElement = keyAndNumberElement.Value;
                    numberElement++;
                    if (dataXml[numberElement] == '<' && dataXml[numberElement + 1] != '/')
                    {
                        KeyValuePair<string, int> nextKeyAndNumberElement = GetKeys(dataXml, numberElement + 1);
                        parsedXmlLines.Add(keyAndNumberElement.Key, nextKeyAndNumberElement.Key);
                    }
                    foreach (KeyValuePair<string, string> keyValue in parsedXmlLines)
                    {
                        Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                    }
                }
            }
            return "";
        }

        public KeyValuePair<string, int> GetKeys(string dataXml, int numberElement)
        {
            StringBuilder keys = new StringBuilder();
            while (dataXml[numberElement] != '>')
            {
                keys.Append(dataXml[numberElement]);
                numberElement++;
            }
            return new KeyValuePair<string, int>(keys.ToString(), numberElement);
        }
    }
}