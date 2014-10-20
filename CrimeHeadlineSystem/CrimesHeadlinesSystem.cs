using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrimeHeadlineSystem
{
    public class CrimesHeadlinesSystem
    {

        internal void FoundCrime(string site, string title)
        {
            Console.WriteLine("Första nyhets-titeln på sidan " + site + " är: " + title + "."); 
        }
    }
}
