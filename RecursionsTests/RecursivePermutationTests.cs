using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursivePermutation;

namespace RecursionsTests
{
    [TestClass]
    public class RecursivePermutationTests
    {
        [TestMethod]
        public void RecursivePermutationTest1()
        {
            //Assign
            var input = "abc";
            var expected = new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };

            //Act
            var result = MySolution.Perm(input);

            //Assert
            CollectionAssert.AreEqual(result, expected, "Result differs from what is expected.");
        }

        [TestMethod]
        public void RecursivePermutationTest2()
        {
            //Assign
            var input = "1234";
            var expected = new List<string>()
            {
                "1234",
                "1243",
                "1324",
                "1342",
                "1423",
                "1432",
                "2134",
                "2143",
                "2314",
                "2341",
                "2413",
                "2431",
                "3124",
                "3142",
                "3214",
                "3241",
                "3412",
                "3421",
                "4123",
                "4132",
                "4213",
                "4231",
                "4312",
                "4321"
        };

            //Act
            var result = MySolution.Perm(input);

            //Assert
            CollectionAssert.AreEqual(result, expected, "Result differs from what is expected.");
        }
    }
}
