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
        /// <returns>Number in the new number system.</returns>
        /// <param name="number">Convertible number.</param>
        /// <param name="numberNewSystemRadix">Number new system radix.</param>
        public string ConvertToDifferentNumberSystems(int number, int numberNewSystemRadix)
        {
            StringBuilder newNumber = new StringBuilder();
            do
            {
                int numberNewSystem = number % numberNewSystemRadix;
                newNumber.Insert(0, controlValues[Math.Abs(numberNewSystem)]);
                number = number / numberNewSystemRadix;
            } while (number != 0);
            return newNumber.ToString();
        }
    }
}
