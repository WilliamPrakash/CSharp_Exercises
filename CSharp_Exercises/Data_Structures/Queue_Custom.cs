using System;
using System.Collections.Generic;


namespace CSharp_Exercises.Data_Structures
{
    // LIFO
    // Examples: Stack Frame, Stack memory
    internal class Queue_Custom<T>
    {
        private readonly List<T> _queue;
        private int size;
        private int pointer;

        public Queue_Custom(int s)
        {
            /* Source: https://stackoverflow.com/questions/33051064/list-c-sharp-capacity-is-always-0-even-though-using-a-constructor-with-capacity
             * With an array initialized with a size, if you try to access an element within the
             * size, it'd be fine and work as expected. Looking at the List<T> constructor, when
             * you pass in a capacity, it's actually doing something very similar using an internal
             * array. So it seems like it should work then, when you try to access any element 
             * less than capacity, but it doesn't. It's actually checking a _size variable 
             * first, and throwing the exception if the index you're requesting is larger than it.
             * If it weren't for that check, it'd work as you expect. */
            this.size = s;
            //this._queue = new List<T>(this.size); // Won't work cause of ^^^
            this._queue = new List<T>(new T[this.size]);
            this.pointer = this.size - 1; // Start at the end of the stack
        }

        public void enqueue(T arg)
        {
            // Check stack capacity
            if (this.pointer < 0)
            {
                throw new Exception("Stack is full.");
            }
            this._queue[this.pointer] = arg;
            this.pointer--;
        }

        // Actually return a value and set that index equal to an empty value
        public T dequeue()
        {
            // Check stack capacity
            if (this.pointer < 0)
            {
                throw new Exception("Stack is full.");
            }
            this.pointer++;
            T ret = this._queue[this.pointer];
            /* Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default
            "default" in the below case is used to produce a default value of a type T. */
            this._queue[this.pointer] = default(T);
            
            return ret;
        }

        public void printQueue()
        {
            if (this.pointer == this.size - 1)
            {
                throw new Exception("Stack is empty.");
            }
            // Print stack from top to bottom, showing the first element to be dequeued at the top
            for (int i = this.pointer + 1; i < this.size; i++)
            {
                Console.WriteLine(this._queue[i]);
            }
        }

        //public void modifyStackSize(int newSize)

    }
}
