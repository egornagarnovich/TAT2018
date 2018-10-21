using System.Text.RegularExpressions;

namespace DEV2
{
  ///<summary>
  /// The StringLanguageDiscover class.
  /// Contains all the methods for determining the type of dictionary translator.
  /// </summary>	
  public class StringLanguageDiscover
  {
    /// <summary>
    /// Gets the string language discover.
    /// </summary>
    /// <returns>The String language discover.</returns>
    /// <param name="inputString">Input text.</param>
    public string GetStringLanguageDiscover(string inputString)
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
