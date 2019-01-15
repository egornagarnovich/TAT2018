using System.Collections.Generic;
namespace task1
{
    /// <summary>
    /// List of pairs of symbols.
    /// Class contains methods for splitting a string into pairs of consecutive characters.
    /// </summary>
    public class ListOfPairsOfSymbols
    {
        /// <summary>
        /// Method for splitting a string into pairs of consecutive characters.
        /// </summary>
        /// <returns>List of pairs of symbols.</returns>
        /// <param name="inputString">Arbitrary character string.</param>
        public List<string> GetList(ref string inputString)
        {
            List<string> couplesSymbols = new List<string>();
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                couplesSymbols.Add(inputString[i].ToString() + inputString[i + 1].ToString());
            }
            return couplesSymbols;
        }
    }
}
