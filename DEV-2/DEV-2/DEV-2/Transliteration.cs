using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;

namespace DEV2
{
  /// <summary>
  /// The Transliteration class.
  /// Contains all text translation methods.
  /// </summary>
  public class Transliteration
  {
    /// <summary>
    /// Receives the translation.
    /// Translates text depending on input arguments.
    /// </summary>
    /// <returns>The translation.</returns>
    /// <param name="language">Language.</param>
    /// <param name="inputString">Input text.</param>
    public string ReceiveTranslation(ref String language, ref String inputString)
    {
      StringBuilder transliteratedString = new StringBuilder();
      transliteratedString.Append(inputString);
      if (language == "english")
      {
	// Parsing json file containing translation dictionary.
	string dictEngInRus = File.ReadAllText("./eng_in_rus.json");
	var serializer = new JavaScriptSerializer();
	var dictionaryTranslator = serializer.Deserialize<Dictionary<string, string>>(dictEngInRus);
	foreach (string elementDict in dictionaryTranslator.Keys)
        {
	  transliteratedString.Replace(elementDict, dictionaryTranslator[elementDict]);
        }
      }
      else
      {
	// Parsing json file containing translation dictionary.		
	string dictEngInRus = File.ReadAllText("./rus_in_eng.json");
        var serializer = new JavaScriptSerializer();
	var dictionaryTranslator = serializer.Deserialize<Dictionary<string,string>>(dictEngInRus);
        foreach (string elementDict in dictionaryTranslator.Keys)
        {
	  transliteratedString.Replace(elementDict, dictionaryTranslator[elementDict]);
        }
      }
      return transliteratedString.ToString();
    }
  }
}
