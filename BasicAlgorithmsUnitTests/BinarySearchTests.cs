using System;
using BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithmsUnitTests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearchIterativeTest()
        {
            var array = new int[] {20, 52, 98, 105, 128, 154, 178};
            var toFind = 20;

            var result = MySolution.BinarySearch(array, toFind);

            Assert.IsTrue(result,"The result differs from what is expected.");
        }
    }
}
