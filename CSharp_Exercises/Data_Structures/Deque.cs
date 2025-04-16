using System;
using System.Collections.Generic;


namespace CSharp_Exercises.Data_Structures
{
    // Double-ended queue (deque), FIFO
    // Allows for insertion and removal of elements from both the front and rear
    internal class Deque<T>
    {
        private List<T> deque;
        private int pointerFront;
        private int pointerBack;
        internal Deque(int size)
        {
            this.deque = new List<T>(new T[size]);
            this.pointerFront = 0;
            this.pointerBack = size - 1;
        }

        internal void enqueueFront(T item)
        {
            // When this.pointerBack is pointing to an index, that index is AVAILABLE to hold new data
            if (this.pointerFront + 1 > this.pointerBack)
            {
                Console.WriteLine("Deque is full");
                return;
            }
            this.deque[this.pointerFront] = item;
            this.pointerFront++;
            
            Console.WriteLine(this.deque);
        }

        internal void enqueueBack(T item)
        {
            // When this.pointerFront is pointing to an index, that index is AVAILABLE to hold new data
            if (this.pointerBack - 1 < this.pointerFront)
            {
                Console.WriteLine("Deque is full");
                return;
            }
            this.deque[this.pointerBack] = item;
            this.pointerBack--;
            
            Console.WriteLine(this.deque);
        }

        internal T dequeueFront()
        {
            // Always going to be removing from the same index: 0
            T dequeuedElement = this.deque[0];
            this.deque.RemoveAt(0);
            this.pointerFront--;
            this.deque.Insert(this.pointerFront, default(T));
            
            return dequeuedElement;
        }

        internal void dequeueBack()
        {
            // Always going to be removing from the same index: size - 1
            
        }

        internal void printDeque()
        {
            // 5 2 17 8 14 7 30 13 1 22
            Console.WriteLine(this.deque);
        }

    }
}
