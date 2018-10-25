using System;
using System.Text;
namespace DEV3
{
    /// <summary>
    /// The Number converter.
    /// Contains all methods for performing basic conversion functions.
    /// </summary>
    public class NumberConverter
    {
        const string controlValues = "0123456789ABCDEFGHIJ";
        /// <summary>
        /// Converts to different number systems.
        /// </summary>
        /// <returns>New system radix.</returns>
        /// <param name="number">Convertible number.</param>
        /// <param name="convertedNumber">Number new system radix.</param>
        public string ConvertToDifferentNumberSystems(int number, int convertedNumber)
        {
            StringBuilder newSystemRadix = new StringBuilder();
            do
            {
                int numberNewSystem = number % convertedNumber;
                newSystemRadix.Insert(0, controlValues[Math.Abs(numberNewSystem)]);
                number = number / convertedNumber;
            } while (number != 0);
            return newSystemRadix.ToString();
        }
    }
}
