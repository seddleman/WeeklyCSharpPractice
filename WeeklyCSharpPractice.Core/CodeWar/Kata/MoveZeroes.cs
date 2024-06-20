using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.CodeWar.Kata
{
   
    public partial class Kata
    {
        // My Solution
        public static int[] MoveZeroes(int[] arr)
        {
            var zeroArray = arr.Where(x => x == 0).ToList();
            var noZeros = arr.Where(x => x != 0).ToList();

            noZeros.AddRange(zeroArray);  // Concat would have been better
            return noZeros.ToArray();
        }

        // Best Solution
        public static int[] xMoveZeroes(int[] arr)
        {
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }

        // Choosen Solution b (but lots of controversy)
        public static int[] yMoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

        
    }
}

/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
