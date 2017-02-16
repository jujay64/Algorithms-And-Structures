using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOthers;

namespace BasicAlgorithmsUnitTests
{
    [TestClass]
    public class SumOfOthersTests
    {
        [TestMethod]
        public void SumOfOthersTestRegular()

        {
            //Arrange
            var input = new int[] {1, 2, 3, 4, 5, 6};
            var expected = new int[] {20, 18, 15, 11, 6, 0};

            //Act
            var result = MySolution.SumOfOthers(input);

            //Assert
            CollectionAssert.AreEqual(result,expected,"Result differs from what was expected.");
        }

        [TestMethod]
        public void SumOfOthersTest1Element()

        {
            //Arrange
            var input = new int[] {2000000000};
            var expected = new int[] {0};

            //Act
            var result = MySolution.SumOfOthers(input);

            //Assert
            CollectionAssert.AreEqual(result, expected, "Result differs from what was expected.");
        }
    }
}
