using System.Collections.Generic;
using System;

namespace WeeklyCSharpPractice.Core.CodeWar.Kata
{
    public partial class Kata
    {
        // My Solution
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            foreach (var value in a)
            {
                if (Array.FindIndex(b, x => x == value) < 0) result.Add(value);
            }

            int[] arr = new int[result.Count];
            int i = 0;
            foreach (int elem in result) arr[i++] = elem;

            return arr;
        }

        // Best Solution
        public static int[] xArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}

/*
Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b keeping their order.

Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
If a value is present in b, all of its occurrences must be removed from the other:

Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
*/
