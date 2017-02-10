using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSum
{
    public static class MySolution
    {
        public static int RecursiveSum(int n)
        {
            if (n == 0)
                return 0;
            return n + RecursiveSum(n - 1);
        }
    }
}
