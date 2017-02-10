using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    public class MySolution
    {
        private static Dictionary<int, int> _cache = new Dictionary<int, int>();

        public static int SimpleRecursiveFibonacci(int n)
        {
            if (n <= 1)
                return n;
            
            return SimpleRecursiveFibonacci(n - 1) + SimpleRecursiveFibonacci(n - 2);
        }

        public static int DynamicRecursiveFibonacci(int n)
        {
            if (n <= 1)
                return n;

            if (!_cache.ContainsKey(n))
                _cache.Add(n, DynamicRecursiveFibonacci(n - 1) + DynamicRecursiveFibonacci(n - 2));
         
            return _cache[n];

        }
        
        public static int IterativeFibonacci(int n)
        {
            if (n <= 1)
                return n;

            var sum = 0;
            var val_n2 = 0;
            var val_n1 = 1;

            for (var i = 2; i <= n; i++)
            {
                sum = val_n1 + val_n2;
                val_n2 = val_n1;
                val_n1 = sum;
            }
            return sum;
        }
    }
}
