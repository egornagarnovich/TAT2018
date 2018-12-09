using System.Collections.Generic;
namespace task1
{
    public class ListOfPairsOfSymbols
    {
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
