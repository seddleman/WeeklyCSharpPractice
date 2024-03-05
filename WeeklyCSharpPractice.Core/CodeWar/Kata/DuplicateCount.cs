using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.CodeWar.Kata
{
    public partial class Kata 
    {
        // My Solution
        public static int DuplicateCount(string str)
        {
            
            var dictionary = new Dictionary<char, int>();
            foreach (var c in str)
            {
                var x = char.ToLower(c);
                if (dictionary.ContainsKey(x)) dictionary[x] += 1;
                else dictionary.Add(x, 1);
            }

            return dictionary.Count(x => x.Value > 1);
        }

        // Best Solution
        public static int xDuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
    }
}

/*
Count the number of Duplicates
Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

Example
"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice
 */