using System;
using System.Collections.Generic;


namespace CSharp_Exercises.Sorting_Algorithms
{
    /* The bubble sort compares every two adjacent values and swaps
       them if the first one is bigger than the second one.
       Time complexity: Best: O(N), Worst: O(N^2) */
    internal class BubbleSort
    {
        private List<int> list;
        public BubbleSort(List<int> list)
        {
            this.list = list;
        }

        public void Sort()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                for(int j = 0; j < this.list.Count; j++)
                {
                    // compare
                    if (j + 1 < this.list.Count && this.list[j] > this.list[j + 1])
                    {
                        int temp = this.list[j + 1];
                        this.list[j + 1] = this.list[j];
                        this.list[j] = temp;
                    }
                }                
            }
            Console.WriteLine(this.list);
        }

    }
}
