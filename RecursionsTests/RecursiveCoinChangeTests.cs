using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveCoinChange;

namespace RecursionsTests
{
    [TestClass]
    public class RecursiveCoinChangeTests
    {
        [TestMethod]
        public void RecursiveCoinChangeTest()
        {
            //Arrange
            var coins = new int[]{1, 5, 10, 21, 25};
            var target = 63;

            var expected = 3;

            //Act
            var result = MySolution.CoinChange(target, coins);

            //Assert
            Assert.AreEqual(result,expected,"Result differs from what is expected.");
        }

        [TestMethod]
        public void RecursiveCoinChangeV2Test()
        {
            //Arrange
            var coins = new int[] { 1, 5, 10, 21, 25 };
            var target = 63;

            var expected = 3;

            //Act
            var result = MySolution.CoinChangeV2(target, coins,new Dictionary<int, int>());

            //Assert
            Assert.AreEqual(result, expected, "Result differs from what is expected.");
        }


        [TestMethod]
        public void IterativeOptimizedCoinChangeV3Test()
        {
            //Arrange
            var coins = new[] { 1, 5, 10, 21, 25 };
            var target = 63;

            var expected = 3;
            var coinUsed = new Dictionary<int,int>();

            //Act           
            var result = MySolution.CoinChangeV3(target, coins,out coinUsed);

            //Console.WriteLine("Change to give back : " + target);
            //Console.WriteLine("Number of coins used : " + result);
            //Console.WriteLine("Coins used : ");
            //PrintUsedCoins(coinUsed, target);
            //Console.ReadKey();

            //Assert
            Assert.AreEqual(result, expected, "Result differs from what is expected.");
        }

        //private void PrintUsedCoins(Dictionary<int,int> coinsUsed, int target)
        //{
        //    while (target > 0)
        //    {
        //        Console.WriteLine(coinsUsed[target]);
        //        target -= coinsUsed[target];
        //    }
        //}
    }
}
