using System;
using System.Text;
namespace DEV3
{
    /// <summary>
    /// The Digital converter.
    /// Contains all methods for performing basic conversion functions.
    /// </summary>
    public class DigitalConverter
    {
	/// <summary>
       /// Converts to different digital systems.
       /// </summary>
       /// <returns>The to different digital systems.</returns>
       /// <param name="number">Number.</param>
       /// <param name="convertedNumber">Digital system.</param>
       public string ConvertToDifferentDigitalSystems(int number, int convertedNumber)
        {
	    string controlValues = "0123456789ABCDEFGHIJ";
	    StringBuilder numberInNewSystem = new StringBuilder(); 
	    do
	    {
	         int numberToAdd = number % convertedNumber;
	         numberInNewSystem.Insert(0, controlValues[Math.Abs(numberToAdd)]);
	         number = number / convertedNumber;
	    } while (number != 0);
	    return numberInNewSystem.ToString();
        }
    }
}
