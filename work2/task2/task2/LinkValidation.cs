using System.Net;
using System;
namespace task2
{
    public class LinkValidation
    {
        public bool IsValidUri(string link)
        {            
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(link);
                return true;
            }
            catch (Exception)
            {
                return false;
            }          
        }
    }
}
