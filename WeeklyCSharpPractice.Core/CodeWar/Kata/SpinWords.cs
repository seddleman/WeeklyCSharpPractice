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
