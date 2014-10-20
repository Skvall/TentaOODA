using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrimeHeadlineSystem
{
    public class UtryckningScraper : IScraper
    {
        private readonly CrimesHeadlinesSystem system;

        public UtryckningScraper(CrimesHeadlinesSystem system)
        {
            this.system = system;
        }



        public string ReadTopCrime()
        {
            throw new NotImplementedException();
        }
    }
}
