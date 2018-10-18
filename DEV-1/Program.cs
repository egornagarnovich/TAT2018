/*
 * This program accept from command line a sequence of characters as the argument.
 * And output to the console a maximal sequence of different symbols in line.
 * 
 * Author: Egor Nagarnovich
 * Version: 1.0.0
 * email: egor.nagarnovich@gmail.com
*/

using System;
using System.Collections.Generic;

namespace DEV1
{
    class MainClass{
        public static void Main(string[] args)
        {
            string inputString = args[0];
            int result = GetResult(inputString);
            Console.WriteLine(result);
        }
        
        public static int GetResult(string inputString)
        {
			/*
             * Method accepts a string line of different symbols from command line
             * Return: Maximal sequence of different symbols
            */

            if (inputString.Length == 1)
                return 1;
            
            int record = 1;
            Stack<char> setChars = new Stack<char>();

            for (int i = 0; i < inputString.Length; i++)
            {
                setChars.Push(inputString[i]);
                for (int j = i + 1; (j < inputString.Length) &&
                     (setChars.Contains(inputString[j]) == false); j++)
                {
                    
                    setChars.Push(inputString[j]);
                    if (setChars.Count > record)
                        {
                            record = setChars.Count;
                        }
                }
                setChars.Clear();  
            }
            return record;
        }
    }
}
