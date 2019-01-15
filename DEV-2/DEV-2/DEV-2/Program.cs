using System;

namespace DEV2
{
    /// <summary>
    /// Main class.
    /// Contains all methods for performing basic functions.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                if (args[0].Length == 0)
                {
                    throw new Exception("Incorrect of argument");
                }
                string inputString = args[0].ToLower();
                StringLanguageDiscover dictionaryLanguage = new StringLanguageDiscover();
                Transliteration translator = new Transliteration();
                string trueDictionary = dictionaryLanguage.GetStringLanguageDiscover(inputString);
                string translatedString = translator.ReceiveTranslation(ref trueDictionary, ref inputString);
                Console.WriteLine(translatedString);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }
    }
}