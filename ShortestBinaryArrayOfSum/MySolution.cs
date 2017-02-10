using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestBinaryArrayOfSum
{
    public static class MySolution
    {

        public static int ShortestBinaryArray(int[] A)
        {
            if (A.Length == 1)
                return 1;

            ulong binarySumA = 0;

            foreach (var i in A) //O(N)
            {
                binarySumA += (ulong)Math.Pow(2, i);
            }

            var rest = binarySumA;
            var counter = 0;
            var pow = 0;

            while (rest > 0) //Find max power of 2
            {   
                if (Math.Pow(2, pow) > rest)
                {
                    pow = 0;
                    counter++;
                }
                else if ((ulong)Math.Pow(2, pow) == rest)
                {
                    rest -= (ulong)Math.Pow(2, pow);
                    counter++;
                }
                else
                {
                    rest -= (ulong)Math.Pow(2, pow);
                    pow++;
                }             
            }
            return counter;
        }
    }
}
