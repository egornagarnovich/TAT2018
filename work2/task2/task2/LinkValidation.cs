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
                Console.WriteLine('q');

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
