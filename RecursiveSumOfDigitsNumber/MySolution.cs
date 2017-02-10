using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSumOfDigitsNumber
{
    public static class MySolution
    {
        public static int RecursiveSumOfDigitsNumber(int n)
        {
            if (n < 10)
                return n;
            return n % 10 + RecursiveSumOfDigitsNumber(n / 10);
        }
    }
}
