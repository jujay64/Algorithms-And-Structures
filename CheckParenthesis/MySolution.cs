using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenericStack;

namespace CheckParenthesis
{
    public static class MySolution
    {
        public static bool CheckParenthesis(string s)
        {
            List<Tuple<char, char>> validCombinaisons = new List<Tuple<char, char>>()
            {
                new Tuple<char, char>('(', ')'),
                new Tuple<char, char>('{', '}'),
                new Tuple<char, char>('[', ']')
            };

            List<char> openingParenthesis = new List<char>(){'(','{','['};

            var stack = new MyGenericStack<char>();

            foreach (var c in s)
            {
                if (openingParenthesis.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.IsEmpty())
                        return false;
                    else
                    {
                        var popItem = stack.Pop();
                        if (!validCombinaisons.Contains(new Tuple<char, char>(popItem, c)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
