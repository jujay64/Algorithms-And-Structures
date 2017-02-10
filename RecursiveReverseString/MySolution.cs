using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveReverseString
{
    public static class MySolution
    {
        public static string RecursiveReverseString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            if (s.Length == 1)
                return s;

            return (s[s.Length - 1].ToString() + RecursiveReverseString(s.Substring(0, s.Length - 1)));
        }
    }
}
