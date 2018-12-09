using System.Text;
namespace task2
{
    public class LinkDetector
    {
        public string GetLink(ref string inputString)
        {
            LinkValidation validator = new LinkValidation();
            string baseLink = "https://";
            StringBuilder link = new StringBuilder();
            if (!inputString.Contains(baseLink))
            {
                return "No link.";
            }
            int index = inputString.IndexOf(baseLink) + baseLink.Length;
            link.Append(baseLink);
            bool startAndStopMarker = false;
            while(startAndStopMarker != true && index != inputString.Length)
            {
                link.Append(inputString[index]);
                startAndStopMarker = validator.IsValidUri(link.ToString());
                index++;
            }
            if (startAndStopMarker == false)
                return "No valid link. " + link.ToString();
            return link.ToString();
        }
    }
}
