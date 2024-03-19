using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeeklyCSharpPractice.Core.CodeWar.Kata
{
    public partial class Kata
    {

        // My Solution
        public static string StripComments(string text, string[] commentSymbols)
        {
            var results = string.Empty;
            var split = text.Split('\n');
            for (int i = 0; i < split.Length; i++)
            {
                results += split[i];
                foreach (var comment in commentSymbols)
                {
                    results = results.IndexOf(comment) != -1 ? results.Substring(0, results.IndexOf(comment)).Trim(' ') : results.Trim(' ');
                }
                results += i < split.Length-1 ? '\n' : "";
            }

            return results;
        }

        // Best Solution
        public static string xStripComments(string text, string[] commentSymbols)
        {
            return string
                .Join("\n", text.Split("\n")
                .Select(x => x.Split(commentSymbols, StringSplitOptions.None)[0]
                .TrimEnd(' ')));
        }

        // My preferred solution
        public static string yStripComments(string text, string[] commentSymbols)
        {
            var texts = text.Split('\n');
            var sb = new StringBuilder();

            foreach (var t in texts)
            {
                int len = commentSymbols.Select(s => t.IndexOf(s)).Where(i => 0 <= i).Append(t.Length).Min();
                sb.Append(t.Substring(0, len).TrimEnd() + "\n");
            }

            return sb.ToString(0, sb.Length - 1);
        }
    }
}


/*
Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the 
line should also be stripped out.

Example:

Given an input string of:

apples, pears # and bananas
grapes
bananas !apples
The output expected would be:

apples, pears
grapes
bananas
The code would be called like so:

string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new [] { "#", "!" })
// result should == "apples, pears\ngrapes\nbananas"

 
 */