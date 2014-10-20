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


    }
}
