using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveWordSplit;

namespace RecursionsTests
{
    /// <summary>
    /// Description résumée pour WordSplitRecursive
    /// </summary>
    [TestClass]
    public class RecursiveWordSplitTests
    {
        [TestMethod]
        public void RecursiveWordSplitTest1()
        {
           //Assign
            var phrase = "themanran";
            var words = new List<string>() {"the", "ran", "man"};
            var expected = new List<string>() {"the", "man", "ran"};

            //Act
            var result = MySolution.WordSplitRecursive(phrase, words);

            //Assert
            CollectionAssert.AreEqual(result,expected,"Result differs from what is expected.");
        }

        [TestMethod]
        public void RecursiveWordSplitTest2()
        {
            //Assign
            var phrase = "ilovedogsJohn";
            var words = new List<string>() { "i","am","a","dogs","lover","love","John" };
            var expected = new List<string>() { "i", "love", "dogs", "John" };

            //Act
            var result = MySolution.WordSplitRecursive(phrase, words);

            //Assert
            CollectionAssert.AreEqual(result, expected, "Result differs from what is expected.");
        }

        [TestMethod]
        public void RecursiveWordSplitTest3()
        {
            //Assign
            var phrase = "themanran";
            var words = new List<string>() { "clown", "ran", "man" }; ;
            var expected = new List<string>();

            //Act
            var result = MySolution.WordSplitRecursive(phrase, words);

            //Assert
            CollectionAssert.AreEqual(result, expected, "Result differs from what is expected.");
        }
    }
}
