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
            StringBuilder keysString = new StringBuilder();
            StringBuilder valuesString = new StringBuilder();
            Dictionary<string, string> aDict = new Dictionary<string, string>();
            Dictionary<string, string> newDict = new Dictionary<string, string>();
            for (int i = 0; i < dataXml.Length - 1; i++)
            {
                if (dataXml[i] == '<' && dataXml[i + 1] != '/')
                {
                    while (dataXml[i + 1] != '>')
                    {
                        keysString.Append(dataXml[i + 1]);
                        i++;
                    }
                    aDict.Add(keysString.ToString(), "");
                    newDict = aDict;
                    aDict.Clear();
                }
                if (dataXml[i] == '>' && dataXml[i + 1] != '<')
                {
                    while (dataXml[i+1] != '<')
                    {
                        valuesString.Append(dataXml[i + 1]);
                        i++;
                    }
                }
            }
            Console.WriteLine(keysString);
            Console.WriteLine(valuesString);
            return keysString.ToString();
        }
    }
}