using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrimeHeadlineSystem
{
    public class PolisenScraper : IScraper
    {
        private readonly CrimesHeadlinesSystem system;

        public PolisenScraper(CrimesHeadlinesSystem system)
        {
            this.system = system;
        }



        public void ReadTopCrime()
        {
            string site = String.Empty;
            string title = String.Empty;

            //kod som scrapear polisen.se efter första nyheten och lägger i site och title variablerna.

            system.FoundCrime(site, title);
        }
    }
}
