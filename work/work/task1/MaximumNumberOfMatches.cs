using System.Collections.Generic;
namespace task1
{
    public class MaximumNumberOfMatches
    {
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
