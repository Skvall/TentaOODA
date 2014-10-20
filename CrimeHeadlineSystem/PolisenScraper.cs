using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Text.RegularExpressions;

namespace CrimeHeadlineSystem
{
    public class PolisenScraper : IScraper
    {
        private readonly CrimesHeadlinesSystem system;

        public PolisenScraper(CrimesHeadlinesSystem system)
        {
            this.system = system;
        }



        public string ReadTopCrime()
        {
            string site = String.Empty;
            string title = String.Empty;

            //kod som scrapear polisen.se efter första nyheten och lägger i site och title variablerna.
            //HttpClient client = new HttpClient();

            title = GetHeadlineTitle();

  

            system.FoundCrime(site, title);

            return title + ", " + site;
        }

        private string GetHeadlineTitle()
        {
            //scrape site for html-content
            WebClient webClient = new WebClient();
            const string strUrl = "http://polisen.se/Aktuellt/Nyheter/";
            byte[] reqHTML;
            reqHTML = webClient.DownloadData(strUrl);
            UTF8Encoding objUTF8 = new UTF8Encoding();
            string htmlContent = objUTF8.GetString(reqHTML);

            //extract title
            string reg1 = "<h3>(.*?)</h3>";

            var aTag = Regex.Matches(htmlContent, @"<a [^>]*>(.*?)</a>").Cast<Match>().Select(m => m.Groups[1].Value);
            var aTagList = aTag.ToList();


            string m1 = Regex.Match(htmlContent, reg1).ToString();

            Console.WriteLine("regexMatch: " + aTagList[0]);
            m1 = Regex.Replace(m1, @"<[^>]*>", string.Empty);
            string title = m1;

            return title;
        }
    }
}
