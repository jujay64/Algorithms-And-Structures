using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPairSum
{
    public class MySolution
    {
        public int ArrayPairSum(int[] arr, int k)
        {
            if (arr.Length < 2)
                return 0;

            var seen = new HashSet<int>();
            var output = new List<Tuple<int,int>>();

            foreach (var num in arr)
            {
                var target = k - num;
                if (seen.Contains(target))
                {
                    output.Add(new Tuple<int, int>(Math.Min(num, target), Math.Max(num, target)));
                }
                else
                {
                    seen.Add(target);
                }
            }
            return output.Count;
        }
    }
}
