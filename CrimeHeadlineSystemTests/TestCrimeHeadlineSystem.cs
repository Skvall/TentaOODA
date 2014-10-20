using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrimeHeadlineSystem;

namespace CrimeHeadlineSystemTests
{
    [TestClass]
    public class TestCrimeHeadlineSystem
    {
        [TestMethod]
        public void Test_ReadTopCrime_on_Polisen()
        {
            ///Arrange
            CrimesHeadlinesSystem system = new CrimesHeadlinesSystem();
            IScraper scraper = new PolisenScraper(system);

            scraper.ReadTopCrime();


            ///Act
            
            ///Assert
            
        }

        [TestMethod]
        public void Test_ReadTopCrime_on_Utryckning()
        {

        }
    }
}
