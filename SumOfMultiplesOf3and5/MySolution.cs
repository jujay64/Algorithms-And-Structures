using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiplesOf3and5
{
    public static class MySolution
    {
        public static int SumOfMultiplesOf3And5(int n)
        {
            if(n < 0)
                throw  new ArgumentException("Input should be non-negative");

            if (n < 3)
                return 0;

            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
