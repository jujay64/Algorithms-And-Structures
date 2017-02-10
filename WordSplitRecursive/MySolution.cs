using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveWordSplit
{
    public static class MySolution
    {
        public static List<string> WordSplitRecursive(string phrase, List<string> words, List<string> output = null)
        {
            if (output == null)
            {
                output = new List<string>();
            }

            foreach (var word in words)
            {
                if (!phrase.StartsWith(word)) continue;
                output.Add(word);
                WordSplitRecursive(phrase.Substring(word.Length), words, output);
            }
            return output;
        }
    }
}
