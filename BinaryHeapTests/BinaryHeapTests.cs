using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreesImplementations;

namespace BinaryHeapTests
{
    [TestClass]
    public class BinaryHeapTests
    {

        [TestMethod]
        public void BuildMyBinaryHeapTest()
        {
            //Assign
            var val = new List<int>() { 9, 6, 5, 2, 3 };
            var expected = new List<int>() {0, 2, 3, 5, 6, 9 };
            var myBinaryHeap = new MyBinaryHeap<int>();

            //Act
            var result = myBinaryHeap.BuildHeapList(val);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Result differs with what is expected");
        }

        [TestMethod]
        public void InsertMyBinaryHeapTest()
        {
            //Assign
            var val = new List<int>() { 9, 6, 5, 2, 3 };
            var expected = new List<int>() { 0, 1, 3, 2, 6, 9, 5 };
            var myBinaryHeap = new MyBinaryHeap<int>();

            //Act
            myBinaryHeap.BuildHeapList(val);
            var result = myBinaryHeap.Insert(1);
            
            //Assert
            CollectionAssert.AreEqual(expected, result, "Result differs with what is expected");
        }
    }
}
