using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class MySolution
    {
        public static bool BinarySearch(int[] arr, int toFind)
        {
            int start = 0;
            int end = arr.Length - 1;
            bool found = false;

            while (start <= end && !found)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == toFind)
                    found = true;
                else
                {
                    if (arr[mid] > toFind)
                        end = mid - 1;
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
            return found;
        }
    }
}
