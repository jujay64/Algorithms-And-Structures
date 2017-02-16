using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOthers
{
    public static class MySolution
    {
        /// <summary>
        /// Problem : Given an array of n integers, make a function that returns an output array where output[i] = sum of input[i+1]...input[n-1] and output[n-1]=0
        /// Example : input = {1, 2, 3, 4, 5, 6}
        ///          output = {20, 18, 15, 11, 6, 0};
        /// </summary>
        /// <param name="array">Input array of integers</param>
        /// <returns>An output array such as : output[i] = sum of input[i+1]...input[n-1] with last element = 0 </returns>
        public static int[] SumOfOthers(int[] array)
        {
            //Edge case
            if (array.Length == 1)
                return new int[] {0};

            var output = new int[array.Length];

            for (var i = array.Length - 2; i >= 0; i--)//We start from the end of the input array to make it with just one loop
            {
                output[i] = output[i + 1] + array[i + 1];
            }

            return output;
        }
    }
}
