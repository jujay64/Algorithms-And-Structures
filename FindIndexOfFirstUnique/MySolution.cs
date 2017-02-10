using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIndexOfFirstUnique
{
    public static class MySolution
    {
        public static int FindIndexOfFirstUnique(string s)
        {
            if (String.IsNullOrEmpty(s))
                return -1;

            if (s.Length == 1)
                return 0;

            var occurences = new Dictionary<char,int>();
            var uniqueChar = Char.MinValue;
            var indexUniqueChar = -1;

            foreach (var c in s)
            {
                if (occurences.ContainsKey(c))
                {
                    occurences[c]++;
                }
                else
                {
                    occurences.Add(c,1);
                }
            }
         
            foreach (var k in occurences.Keys)
            {
                if (occurences[k] == 1)
                {
                    uniqueChar = k;
                    break;
                }
            }

            if (uniqueChar == Char.MinValue)
                return -1;
            else
            {
                for (var i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == uniqueChar)
                    {
                        indexUniqueChar = i;
                        break;
                    }
                }
            }
            return indexUniqueChar;
        }
    }
}
