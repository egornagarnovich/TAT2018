using System;
using System.Collections.Generic;

namespace DEV1
{
    class MainClass{
        public static void Main(string[] args)
        {
            string input_string = args[0];
            int result = GetResult(input_string);
            Console.WriteLine(result);
        }
        
        public static int GetResult(string input_string)
        {
            if (input_string.Length == 1)
                return 1;
            
            int record = 1;
            Stack<char> set_chars = new Stack<char>();

            for (int i = 0; i < input_string.Length; i++)
            {
                set_chars.Push(input_string[i]);
                for (int j = i + 1; (j < input_string.Length) &&
                     (set_chars.Contains(input_string[j]) == false); j++)
                {
                    
                    set_chars.Push(input_string[j]);
                    if (set_chars.Count > record)
                        {
                            record = set_chars.Count;
                        }
                }
                set_chars.Clear();  
            }
            return record;
        }
    }
}