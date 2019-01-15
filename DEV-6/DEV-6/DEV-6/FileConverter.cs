using System.Text;
using System.Collections.Generic;

namespace DEV6
{
    /// <summary>
    /// File converter.
    /// This class contains methods that convert xml file to json or set.
    /// </summary>
    public class FileConverter
    {
        /// <summary>
        /// Converts to xml.
        /// </summary>
        /// <returns>Converted string.</returns>
        /// <param name="jsonString">Json string.</param>
        public string ConvertToXml(string jsonString)
        {
            jsonString = jsonString.Replace(" ", "");
            jsonString = jsonString.Replace("\n", "");
            StringBuilder xmlString = new StringBuilder();
            List<string> keysArray = new List<string>();
            xmlString.Append("<?xml version='1.0' encoding='UTF - 8'?>\n");
            xmlString.Append("<root>\n  ");
            for (int i = 0; i < jsonString.Length; i++)
            {
                if (jsonString[i] == '{' && jsonString[i + 1] == '"')
                {
                    StringBuilder key = new StringBuilder();
                    i += 2;
                    xmlString.Append('<');
                    while (jsonString[i] != '"')
                    {
                        key.Append(jsonString[i]);
                        i++;
                    }
                    keysArray.Add(key.ToString());
                    xmlString.Append(key);
                    xmlString.Append(">\n\t");
                }
                if (jsonString[i] == ':' && jsonString[i + 1] == '"')
                {
                    string newJsonString = jsonString.Substring(i);
                    xmlString.Append(GetNextElement(ref newJsonString, ref i));
                    xmlString.Append("</" + keysArray[keysArray.Count - 1]);
                    keysArray.RemoveAt(keysArray.Count - 1);
                }
                if (jsonString[i] == ':' && jsonString[i + 1] == '[' && jsonString[i + 2] == '{')
                {
                    xmlString.Append("<element>\n\t  ");
                    StringBuilder value = new StringBuilder();
                    i += 3;
                    xmlString.Append('<');
                    while (jsonString[i] != '"')
                    {
                        value.Append(jsonString[i]);
                        i++;
                    }
                    xmlString.Append(value);
                    xmlString.Append(">\n\t\t");
                }
                if (jsonString[i] == ':' && jsonString[i + 1] == '[' && jsonString[i + 2] == '"')
                {
                    xmlString.Append("<element>");
                    StringBuilder value = new StringBuilder();
                    i += 3;
                    while (jsonString[i] != '"')
                    {
                        value.Append(jsonString[i]);
                        i++;
                    }
                    xmlString.Append(value);
                    xmlString.Append("</element>\n\t\t");
                    if (jsonString[i] == ',')
                    {
                        xmlString.Append("<element>");
                        string newJsonString = jsonString.Substring(i);
                        xmlString.Append(GetNextElement(ref newJsonString, ref i));
                        xmlString.Append("</element>\n\t\t");
                    }
                }
                if (jsonString[i] == ']' && jsonString[i + 1] == '}')
                {
                    xmlString.Append("</");
                    xmlString.Append(keysArray[keysArray.Count - 1]);
                    keysArray.RemoveAt(keysArray.Count - 1);
                    xmlString.Append(">\n");
                }
                

            }
            return xmlString.ToString();
        }

        /// <summary>
        /// Converts to json.
        /// </summary>
        /// <returns>Converted string.</returns>
        /// <param name="xmlString">Xml string.</param>
        public string ConvertToJson(string xmlString)
        {
            StringBuilder jsonString = new StringBuilder();
            jsonString.Append(xmlString);
            for (int i = 0; i < jsonString.Length; i++)
            {
                if (jsonString[i] == '<' && jsonString[i] == '?')
                {
                    while (jsonString[i] != '<')
                    {
                        if (jsonString[i] != ' ')
                        {
                            jsonString.Remove(i, 1);
                            i++;
                        }
                    }
                }
                if (jsonString[i] == '<' && jsonString[i + 1] == '/')
                {
                    i++;
                    while (jsonString[i] != '>')
                    {
                        jsonString.Remove(i, 1);
                        i++;
                    }
                }
            }
            jsonString.Replace('<', '"');
            jsonString.Replace('>', '"');
            return jsonString.ToString();
        }

        /// <summary>
        /// Gets the next element.
        /// </summary>
        /// <returns>The next element in string.</returns>
        /// <param name="jsonString">Json string.</param>
        /// <param name="i">The index of element in string.</param>
        public string GetNextElement(ref string jsonString, ref int i)
        {
            StringBuilder value = new StringBuilder();
            while (jsonString[i] != '"')
            {
                value.Append(jsonString[i]);
                i++;
            }
            return value.ToString();
        }
    }
}