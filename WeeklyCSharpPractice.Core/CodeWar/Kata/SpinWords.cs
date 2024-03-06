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
        public static string SpinWords(string sentence)
        {
            var results = string.Empty;
            var words = sentence.Split(' ');
            foreach (var word in words)
            {
                if (word.Length >= 5)
                {
                    char[] charArray = word.ToCharArray();
                    Array.Reverse(charArray);
                    results += (new String(charArray) + " ");
                }
                else results += (word + " ");
            }
            
            return results.TrimEnd();
        }

        // Best Solution
        public static string xSpinWords(string sentence)
        {
            return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }

        // Second Best Solution
        public static string ySpinWords(string sentence)
        {
            var words = sentence.Split(' ').Where(w => w.Length > 4);
            foreach (var w in words) sentence = sentence.Replace(w, Reverse(w));  // Used replace, didn't rewrite the sentence
            return sentence;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

/*
 Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed 
(Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

Examples:

"Hey fellow warriors"  --> "Hey wollef sroirraw" 
"This is a test        --> "This is a test" 
"This is another test" --> "This is rehtona test"
 */