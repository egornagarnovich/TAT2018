using System.Text.RegularExpressions;

namespace DEV2
{
  ///<summary>
  /// The TrueDictionary class.
  /// Contains all the methods for determining the type of dictionary translator.
  /// </summary>	
  public class TrueDictionary
  {
    /// <summary>
    /// Gets the true dictionary.
    /// </summary>
    /// <returns>The true dictionary.</returns>
    /// <param name="inputString">Input text.</param>
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
  
    /// <summary>
    /// Identifies the russian.
    /// </summary>
    /// <returns><c>true</c>, if russian was identifyed, <c>false</c> otherwise.</returns>
    /// <param name="inputString">Input text.</param>
    public bool IdentifyRussian(string inputString)
    {
      return Regex.IsMatch(inputString, "[а-яА-ЯеЁ]");
    }
  }
}
