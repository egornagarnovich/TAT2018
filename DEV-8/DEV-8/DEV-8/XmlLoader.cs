using System.Xml;
namespace DEV8
{
    /// <summary>
    /// Class contains methods for loading xml file
    /// </summary>
    public class XmlLoader
    {
        /// <summary>
        /// Loads the xml.
        /// </summary>
        /// <returns>Data xml.</returns>
        /// <param name="pathToXml">Path to xml.</param>
        public XmlDocument LoadXml(ref string pathToXml)
        {
            XmlDocument document = new XmlDocument();
            document.Load(pathToXml);
            return document;
        }
    }
}