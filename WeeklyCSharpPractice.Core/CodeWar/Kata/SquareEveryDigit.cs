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
        public static int SquareDigits(int n)
        {
            var result = string.Empty;
            foreach (char c in n.ToString())
            {
                var value = Int32.Parse(c.ToString());
                result += (value * value).ToString();
            }

            return Int32.Parse(result);
        }

        // Best Solution
        public static int xSquareDigits(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
            }
            return int.Parse(output);
        }
    }
}


/*
Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 9^2 is 81 and 1^2 is 1. (81-1-1-81)

Example #2: An input of 765 will/should return 493625 because 7^2 is 49, 6^2 is 36, and 5^2 is 25. (49-36-25)

Note: The function accepts an integer and returns an integer.

Happy Coding!

 */