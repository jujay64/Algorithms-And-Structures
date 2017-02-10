using System;
using FindIndexOfFirstUnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithmsUnitTests
{
    [TestClass]
    public class FindIndexOfFirstUniqueTests
    {
        [TestMethod]
        public void FindIndexOfFirstUniqueExistTest()
        {
            //Assign
            var input = "aabbceeddff";

            var expected = 4;

            //Act
            var result = MySolution.FindIndexOfFirstUnique(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");
        }

        [TestMethod]
        public void FindIndexOfFirstUniqueAbsentTest()
        {
            //Assign
            var input = "aabbcceeddff";

            var expected = -1;

            //Act
            var result = MySolution.FindIndexOfFirstUnique(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");
        }

        [TestMethod]
        public void FindIndexOfFirstUniqueAllUniqueTest()
        {
            //Assign
            var input = "abcedf";

            var expected = 0;

            //Act
            var result = MySolution.FindIndexOfFirstUnique(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");
        }


        [TestMethod]
        public void FindIndexOfFirstUnique1CharTest()
        {
            //Assign
            var input = "a";

            var expected = 0;

            //Act
            var result = MySolution.FindIndexOfFirstUnique(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");
        }

        [TestMethod]
        public void FindIndexOfFirstUniqueEmptyInputTest()
        {
            //Assign
            var input = "";

            var expected = -1;

            //Act
            var result = MySolution.FindIndexOfFirstUnique(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");
        }

        [TestMethod]
        public void FindIndexOfFirstUniqueEmptyNullTest()
        {
            //Assign
            string input = null;

            var expected = -1;

            //Act
            var result = MySolution.FindIndexOfFirstUnique(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");
        }
    }
}
