using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestBinaryArrayOfSum;

namespace BasicAlgorithmsUnitTests
{
    [TestClass]
    public class ShortestBinaryArray
    {
        [TestMethod]
        public void ShortestBinaryArrayLength1()
        {
            //Arrange
            var testArray = new int[] {4};
            var expected = 1;

            //Act
            var result = MySolution.ShortestBinaryArray(testArray);

            //Assert
            Assert.AreEqual(result,expected,"Result differs from what is expected.");
        }

        [TestMethod]
        public void ShortestBinaryArrayTest1()
        {
            //Arrange
            var testArray = new int[] { 3,0,0,1,0 };
            var expected = 3;

            //Act
            var result = MySolution.ShortestBinaryArray(testArray);

            //Assert
            Assert.AreEqual(result, expected, "Result differs from what is expected.");
        }

        [TestMethod]
        public void ShortestBinaryArrayTest2()
        {
            //Arrange
            var testArray = new int[] { 15,3, 0, 5, 1 };
            var expected = 5;

            //Act
            var result = MySolution.ShortestBinaryArray(testArray);

            //Assert
            Assert.AreEqual(result, expected, "Result differs from what is expected.");
        }
    }
}
