using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveSum;

namespace RecursionsTests
{
    [TestClass]
    public class RecursiveSumTests
    {
        [TestMethod]
        public void RecursiveSumOf4()
        {
            //Arrange
            var n = 4;
            var expected = 10;

            //Act
            var result = MySolution.RecursiveSum(n);

            //Assert
            Assert.AreEqual(expected,result,"Result differs from what is expected");
        }

        [TestMethod]
        public void RecursiveSumWithFormula()
        {
            //Arrange
            var n = 1000;
            var expected = (n*(n+1))/2;

            //Act
            var result = MySolution.RecursiveSum(n);

            //Assert
            Assert.AreEqual(expected, result, "Result differs from what is expected");
        }
    }
}
