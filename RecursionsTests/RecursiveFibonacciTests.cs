using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveFibonacci;

namespace RecursionsTests
{
    [TestClass]
    public class RecursiveFibonacciTests
    {
        [TestMethod]
        public void SimpleRecursiveFibonacciTest()
        {
            //Assign
            var n = 10;
            var expected = 55;

            //Act
            var result = MySolution.SimpleRecursiveFibonacci(n);

            //Assert
            Assert.AreEqual(result,expected,"Result differs from what is expected.");
        }

        [TestMethod]
        public void DynammicRecursiveFibonacciTest()
        {
            //Assign
            var n = 10;
            var expected = 55;

            //Act
            var result = MySolution.DynamicRecursiveFibonacci(n);

            //Assert
            Assert.AreEqual(result, expected, "Result differs from what is expected.");
        }

        [TestMethod]
        public void IterativeFibonacciTest()
        {
            //Assign
            var n = 23;
            var expected = 28657;

            //Act
            var result = MySolution.IterativeFibonacci(n);

            //Assert
            Assert.AreEqual(result, expected, "Result differs from what is expected.");
        }
    }
}
