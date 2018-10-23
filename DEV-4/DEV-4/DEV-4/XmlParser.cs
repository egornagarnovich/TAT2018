using System;
using System.Text.RegularExpressions;
namespace DEV4
{
    public class XmlParser
    {
		public string ParseXml(ref string dataXml)
        {
			dataXml = dataXml.Replace(" ", "");
			dataXml = dataXml.Replace("\n", "");
			return dataXml;
        }
    }

	public class XmlSorter: XmlParser
	{
		public string SortXml()
		{
			return "0";
		}
	}
}
