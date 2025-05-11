using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_Exercises.Sorting_Algorithms;

/* Best/Worst: O(N^2)
The selection sort algorithm finds the minimum value
in the data structure, places it in the first position,
then finds the second minimum value, places it into the 
second position, and so on.
*/
public class SelectionSort
{
    private int[] array;

    public SelectionSort(int[] arr)
    {
        this.array = arr;
    }

    public int[] Sort()
    {
        for (int i = 0; i < this.array.Length; i++)
        {
            int min = this.array[i];
            int minIndex = i;
            // Find the smallest int value
            // Put that value into the first position
            // Find the second smallest one, etc.
            for (int j = i; j < this.array.Length; j++)
            {
                if (this.array[j] < min)
                {
                    min = this.array[j];
                    minIndex = j;
                }
            }
            Console.WriteLine(this.array);

            // Swap
            int temp = this.array[i];
            this.array[i] = this.array[minIndex];
            this.array[minIndex] = temp;

        }

        return this.array;
    }
}
