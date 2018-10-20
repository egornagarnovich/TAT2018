using System;

namespace DEV2
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      try
      {
        if (args[0].Length == 0)
	{
	  throw new Exception("Incorrect of argument");
	}
	string inputString = args[0].ToLower();
	TrueDictionary enty = new TrueDictionary();
	Transliteration reg = new Transliteration();
	string result = enty.GetTrueDictionary(inputString);
	string translatedString = reg.ReceiveTranslation(ref result, ref inputString);
	Console.WriteLine(translatedString);
	}
	catch (Exception error)
	{
	  Console.WriteLine("Error: " + error.Message);
	}
      }
   }
}
