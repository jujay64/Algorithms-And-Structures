using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveSumOfDigitsNumber;

namespace RecursionsTests
{
    [TestClass]
    public class RecursiveSumOfDigitsNumberTests
    {
        [TestMethod]
        public void RecursiveSumOfDigitsNumberFor4321()
        {
            //Assign
            var n = 4321;
            var expected = 10;

            //Act
            var result = MySolution.RecursiveSumOfDigitsNumber(n);

            Assert.AreEqual(result, expected, "Result differs from what is expected");
        }
    }
}
