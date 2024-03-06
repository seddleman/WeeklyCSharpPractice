using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.CodeWar.Kata
{
    public partial class Kata
    {
        public static int FindTheOddInt(int[] seq)
        {

       //     var x = seq.GroupBy(c => c).Where(g => g.Count() % 2 != 0).First().Key;

            return seq.GroupBy(c => c).Where(g => g.Count() % 2 != 0).First().Key;
        }
    }
}

/*
Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.

Examples
[7] should return 7, because it occurs 1 time (which is odd).
[0] should return 0, because it occurs 1 time (which is odd).
[1,1,2] should return 2, because it occurs 1 time (which is odd).
[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
 */
