using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;

namespace DEV2
{
  public class Transliteration
  {
    public string ReceiveTranslation(ref String language, ref String inputString)
    {
      StringBuilder transliteratedString = new StringBuilder();
      transliteratedString.Append(inputString);
      if (language == "english")
      {
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
