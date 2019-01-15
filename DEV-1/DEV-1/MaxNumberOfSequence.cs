using System.Collections.Generic;

namespace DEV1
{
    /// <summary>
    /// The MaxNumberOfSequence class.
    /// Contains all methods for performing basic count functions.
    /// </summary>
    public class MaxNumberOfSequence
    {
        /// <summary>
        /// Method accepts a string line of different symbols from command line.
        /// </summary>
        /// <returns>Maximal sequence of different symbols.</returns>
        /// <param name="inputString">Character sequence.</param>
        public int  GetLengthOfSequence (string inputString)
        {
            if (inputString.Length == 1)
            return inputString.Length;
            int maxLength = 1;
            Stack<char> setOfUniqueVariables = new Stack<char>();
            for (int i = 0; i < inputString.Length; i++)
            {
                setOfUniqueVariables.Push(inputString[i]);
                for (int j = i + 1; (j < inputString.Length) && 
                (setOfUniqueVariables.Contains(inputString[j]) == false); j++)
                {
                    setOfUniqueVariables.Push(inputString[j]);
                    if (setOfUniqueVariables.Count > maxLength)
                    {
                        maxLength = setOfUniqueVariables.Count;
                    }
                }
                setOfUniqueVariables.Clear();
            }
            return maxLength;
        }
    }
}