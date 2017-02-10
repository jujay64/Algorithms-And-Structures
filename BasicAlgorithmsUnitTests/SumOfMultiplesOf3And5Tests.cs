using System;
using System.CodeDom;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfMultiplesOf3and5;

namespace BasicAlgorithmsUnitTests
{
    [TestClass]
    public class SumOfMultiplesOf3And5Tests
    {
        [TestMethod]
        public void SumOfMultiplesOf3And5ResultFor10()
        {
            //Arrange
            const int n = 10;
            const int expected = 23;

            //Act
            var actual = MySolution.SumOfMultiplesOf3And5(n);
            //Assert
            Assert.AreEqual(expected,actual,"Result is not what is expected");
        }

        [TestMethod]
        public void SumOfMultiplesOf3And5ResultFor1000()
        {
            //Arrange
            const int n = 1000;
            const int expected = 233168;

            //Act
            var actual = MySolution.SumOfMultiplesOf3And5(n);

            //Assert
            Assert.AreEqual(expected, actual, "Result is not what is expected");
        }
    }
}
