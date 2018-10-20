using System.Text.RegularExpressions;

namespace DEV2
{
  public class TrueDictionary
  {
    public string GetTrueDictionary(string inputString)
    {
      string dictionaryLanguage = "";
      if (IdentifyRussian(inputString) == true)
      {
	dictionaryLanguage = "russian";
      }
      else
      {
	dictionaryLanguage = "english";
      }
      return dictionaryLanguage;
    }

    public bool IdentifyRussian(string inputString)
    {
      return Regex.IsMatch(inputString, "[а-яА-ЯеЁ]");
    }
  }
}
