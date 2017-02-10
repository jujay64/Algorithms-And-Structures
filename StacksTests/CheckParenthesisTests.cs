using System;
using CheckParenthesis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StacksTests
{
    [TestClass]
    public class CheckParenthesisTests
    {
        [TestMethod]
        public void TestOK()
        {
            //Arrange
            var s = "{[()]}";

            //Act
            var result = MySolution.CheckParenthesis(s);

            //Assert
            Assert.IsTrue(result, "Result differs from what is expected.");
        }

        [TestMethod]
        public void TestKO()
        {
            //Arrange
            var s = "{[([)]}";

            //Act
            var result = MySolution.CheckParenthesis(s);

            //Assert
            Assert.IsFalse(result, "Result differs from what is expected.");
        }
    }
}
