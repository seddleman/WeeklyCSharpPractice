using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.CodeWar.Kata
{

    public partial class Kata
    {
        // My Solution
        public static int xFindOddOrEven(int[] integers)
        {
            var count = 0;
            int even = 0;
            int odd = 0;
            foreach (var n in integers)
            {
                if (n % 2 != 0)  // is Odd
                {
                    count++;
                    odd = n;
                }
                else even = n;
            }

            return (count > 1) ? even : odd;
        }

        // Best Solution
        public static int FindOddOrEven(int[] integers)
        {
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
        }
    }
}

/* 
 You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely 
comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument 
and returns this "outlier" N.

Examples
[2, 4, 0, 100, 4, 11, 2602, 36] -->  11 (the only odd number)

[160, 3, 1719, 19, 11, 13, -21] --> 160 (the only even number)
 */
