using System.Collections.Generic;
namespace task1
{
    /// <summary>
    /// Maximum number of matches.
    /// The class contains all methods for defining a pair of consecutive letters
    /// that are most often found in a string.
    /// </summary>
    public class MaximumNumberOfMatches
    {
        /// <summary>
        /// Gets the maximum number of matches.
        /// </summary>
        /// <returns>Pair of consecutive letters that are most often found in a string.</returns>
        /// <param name="inputString">Arbitrary character string.</param>
        public string GetMaximumNumberOfMatches(ref string inputString)
        {
            ListOfPairsOfSymbols pairsOfSymbols = new ListOfPairsOfSymbols();
            List<string> couplesSymbols = pairsOfSymbols.GetList(ref inputString);
            int index = 0;
            int controlCounter = 0;
            foreach (string couples in couplesSymbols)
            {
                int count = 0;
                int startAndStopMarker = inputString.IndexOf(couples);
                while (startAndStopMarker != -1)
                {
                    count++;
                    startAndStopMarker = inputString.IndexOf(couples, startAndStopMarker + couples.Length);
                }
                if (count > controlCounter)
                {
                    index = couplesSymbols.IndexOf(couples);
                }
            }
            return couplesSymbols[index];
        }
    }
}
