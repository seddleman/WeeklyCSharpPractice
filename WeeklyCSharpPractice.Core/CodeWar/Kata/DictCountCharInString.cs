using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.CodeWar.Kata
{
    public partial class Kata
    {
        public static Dictionary<char, int> DictCountCharInString(string str)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (dictionary.ContainsKey(c)) dictionary[c] += 1;
                else dictionary.Add(c, 1);
            }
            return dictionary;
        }
    
        // Linq Solution (rated best, but my solution is 2nd best)
        public static Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
/*
The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

What if the string is empty? Then the result should be empty object literal, {}.
*/
