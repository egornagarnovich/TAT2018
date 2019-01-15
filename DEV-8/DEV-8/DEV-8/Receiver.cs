using System.Collections.Generic;
using System.Xml;
using System;
namespace DEV8
{
    /// <summary>
    /// Receiver.
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Gets the number of brands.
        /// </summary>
        /// <returns>The number of brands.</returns>
        /// <param name="dataXml">Data xml.</param>
        public int GetNumberOfBrands(XmlDocument dataXml)
        {
            List<string> data = new List<string>();
            foreach (XmlNode element in dataXml.GetElementsByTagName("Brand"))
            {
                data.Add(element.InnerText);
            }
            return data.Count;
        }

        /// <summary>
        /// Gets the price all auto.
        /// </summary>
        /// <returns>The price all auto.</returns>
        /// <param name="dataXml">Data xml.</param>
        public int GetPriceAllAuto(XmlDocument dataXml)
        {
            int priceAllAuto = 0;
            foreach (XmlNode element in dataXml.GetElementsByTagName("Quantity"))
            {
                priceAllAuto += Int32.Parse(element.InnerText);
            }
            return priceAllAuto;
        }

        /// <summary>
        /// Gets the average price auto.
        /// </summary>
        /// <returns>The average price auto.</returns>
        /// <param name="dataXml">Data xml.</param>
        public int GetAveragePriceAuto(XmlDocument dataXml)
        {
            int priceAllAuto = GetPriceAllAuto(dataXml);
            int count = 0;
            int sumOfUnitCost = 0;
            int averageUnitCost = 0;
            foreach (XmlNode element in dataXml.GetElementsByTagName("UnitCost"))
            {
                sumOfUnitCost += Int32.Parse(element.InnerText);
                count++;
            }
            averageUnitCost = sumOfUnitCost / count;
            return averageUnitCost / GetNumberOfBrands(dataXml);
        }
    }
}