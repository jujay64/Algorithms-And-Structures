using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePermutation
{
    public static class MySolution
    {
        public static List<string> Perm(string s)
        {
            List<string> l = new List<string>();

            if (s.Length == 1)
            {
                l.Add(s);
            }

            else
            {
                var i = 0;
                foreach (var let in s)
                {
                    foreach (var perm in Perm(s.Substring(0, i) + s.Substring(i + 1)))
                    {
                        l.Add(let + perm);
                    }
                    i++;
                }
            }
            return l;
        }
    }
}
