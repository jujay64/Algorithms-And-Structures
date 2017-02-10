using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCoinChange
{
    public static class MySolution
    {
        //SIMPLE BUT REALLY NOT OPTIMAL
        public static int CoinChange(int target, int[] coins)
        {
            if (coins.Contains(target))
                return 1;

            var minCoins = target;

            foreach (var c in coins.Where(c => c <= target))
            {
                var numCoins = 1 + CoinChange(target - c, coins);
                if (numCoins < minCoins)
                    minCoins = numCoins;
            }
            return minCoins;
        }

        //USING A CACHE
        public static int CoinChangeV2(int target, int[] coins, Dictionary<int, int> knownResults)
        {
            if (coins.Contains(target))
            {
                if (knownResults.ContainsKey(target))
                    knownResults[target] = 1;
                else
                {
                    knownResults.Add(target, 1);
                }
                return 1;
            }
            else if (knownResults.ContainsKey(target))
                return knownResults[target];

            var minCoins = target;

            foreach (var c in coins.Where(c => c <= target))
            {
                var numCoins = 1 + CoinChangeV2(target - c, coins, knownResults);
                if (numCoins < minCoins)
                {
                    minCoins = numCoins;
                    if (knownResults.ContainsKey(target))
                        knownResults[target] = minCoins;
                    else
                    {
                        knownResults.Add(target, minCoins);
                    }
                }
            }
            return minCoins;
        }

        //NB : THIS IS AN ITERATIVE APPROCH USING DYNAMIC PROGRAMMING
        public static int CoinChangeV3(int target, int[] coins,out Dictionary<int,int> coinUsed)
        {
            coinUsed = new Dictionary<int, int>();
            var minCoins = new Dictionary<int, int>();
            minCoins[0] = 0;
            var newCoin = 1;

            for (var cents = 1; cents <= target; cents++)
            {
                var coinCount = cents;
                foreach (var j in coins.Where(c => c <= cents))
                {
                    if (minCoins[cents - j] + 1 < coinCount)
                    {
                        coinCount = minCoins[cents - j] + 1;
                        newCoin = j;
                    }
                }
                minCoins[cents] = coinCount;
                coinUsed[cents] = newCoin;
            }
            return minCoins[target];
        }
    }
}
