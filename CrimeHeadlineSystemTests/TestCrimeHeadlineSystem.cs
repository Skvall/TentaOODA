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
            


            ///Act
            string actual = scraper.ReadTopCrime();

            ///Assert
            Assert.IsNotNull(actual);    ///<--- måste ändra detta, ger false positive?
        }

        [TestMethod]
        public void Test_ReadTopCrime_on_Utryckning()
        {
            ///Assert



            ///Act


            ///Assert

        }
    }
}
