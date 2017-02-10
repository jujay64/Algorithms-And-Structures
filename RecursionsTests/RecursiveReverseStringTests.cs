using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveReverseString;

namespace RecursionsTests
{
    [TestClass]
    public class RecursiveReverseStringTests
    {
        [TestMethod]
        public void RecursiveReverseStringTest1()
        {
            //Assign
            var input = "hello";
            var expected = "olleh";

            //Act
            var result = MySolution.RecursiveReverseString(input);

            //Assert
            Assert.AreEqual(result,expected,"The result differs from what is expected.");

        }

        [TestMethod]
        public void RecursiveReverseStringTest2()
        {
            //Assign
            var input = "hello world";
            var expected = "dlrow olleh";

            //Act
            var result = MySolution.RecursiveReverseString(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");

        }

        [TestMethod]
        public void RecursiveReverseStringTest3()
        {
            //Assign
            var input = "123456789";
            var expected = "987654321";

            //Act
            var result = MySolution.RecursiveReverseString(input);

            //Assert
            Assert.AreEqual(result, expected, "The result differs from what is expected.");

        }
    }
}
