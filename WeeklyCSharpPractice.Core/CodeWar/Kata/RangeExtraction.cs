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
        public static string RangeExtraction(int[] args)
        {
            if (args.Length == 0) return "";

            var results = string.Join(',', args.Select(x => x.ToString()));
            var segments = new List<string>();
            var previous = args[0];
            List<int> remove = new List<int>();
            var seg = string.Empty;
            for (int i = 1; i < args.Length; i++)
            {
                if ((args[i] == previous + 1) && (seg.Length > 0)) seg += previous.ToString() + ",";
                if ((args[i] == previous + 1) && (seg.Length == 0)) seg += ","; 
                if (args[i] != previous + 1)
                {
                    if (seg.Length >= 3) segments.Add(seg);
                    seg = string.Empty;
                }
                previous = args[i];
            }
            if (seg.Length >=3) segments.Add(seg);

            foreach (var s in segments) results = results.Replace(s, "-");
           
            return results;  
        }
    }
}

/*

A format for expressing an ordered list of integers is to use a comma separated list of either

individual integers
or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

Example:

solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
 
*/
