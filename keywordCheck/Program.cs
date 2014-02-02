using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace keywordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var url = "http://www.gametrailers.com";
            var keywords = "final fantasy";
            var pageContent = client.DownloadString(url);
            var keywordLocation = pageContent.IndexOf(keywords, StringComparison.OrdinalIgnoreCase);
            if (keywordLocation >= 0)
            {
                Console.WriteLine(url + " are talking about " + keywords + " today.");
                Console.WriteLine("\nSnippet:\n" + pageContent.Substring(keywordLocation, 100));
            }
            Console.ReadKey();
        }
    }
}
