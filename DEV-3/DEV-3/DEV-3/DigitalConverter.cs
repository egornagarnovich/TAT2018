using System;
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
	    return Convert.ToString(number, convertedNumber);
        }
    }
}
