using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercises.Sorting_Algorithms;

/* Source: https://www.geeksforgeeks.org/binary-search/
The Binary Search Algorithm is a searching algorithm used in a sorted array by repeatedly
dividing the search interval in half. The idea of a binary search is to use the information
that the array is sorted and reduce the time complexity to O(log N). */

public class BinarySearch
{
    private int[] arr;
    private int size;

    public BinarySearch(int[] arr)
    {
        this.arr = arr;
        this.size = arr.Length;
    }

    public int Sort(int find) // Return index of find if found, else -1
    {
        /* Source: https://stackoverflow.com/questions/40141329/c-sharp-variable-automatically-rounds-down-while-its-set-to-round-to-2-decimal
        As surprising as it might sound, decimal a = 10 / 4; ,will yield 2,
        not 2.5. That's because the / operator performs an integer division if
        both its operands (10 and 4) are integers: */

        // Bottom, top, and midpoint of the search area.
        int bottom = 0;
        int midpoint = this.size / 2;
        int top = this.size - 1;

        // Narrow index range of "find" down.
        while (midpoint <= top)
        {
            /* midpoint calculation:
            1. Calculate range of current search window.
            2. Divide by 2 to find the halfway point of that range.
            3. Add bottom range to shift search window appropriately. */
            midpoint = bottom + ((top - bottom) / 2);

            if (find > this.arr[midpoint])
            {
                // Look above
                bottom = midpoint + 1;
            }
            else if (find == this.arr[midpoint])
            {
                return midpoint;
            }
            else if (find > this.arr[midpoint])
            {
                // Look below
                top = midpoint - 1;
            }
        }

        return -1;
    }
}
