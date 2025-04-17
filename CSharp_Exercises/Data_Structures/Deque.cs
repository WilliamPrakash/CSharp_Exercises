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
        private int size;
        internal Deque(int s)
        {
            this.size = s;
            this.deque = new List<T>(new T[this.size]);
            this.pointerFront = 0;
            this.pointerBack = this.size - 1;
        }

        internal void enqueueFront(T item)
        {
            // When this.pointerBack is pointing to an index, that index is AVAILABLE to hold new data
            if (this.pointerFront > this.pointerBack)
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
            if (this.pointerBack < this.pointerFront)
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

        internal T dequeueBack()
        {
            // Always going to be removing from the same index: size - 1
            T dequeuedElement = this.deque[this.size - 1];
            this.deque.RemoveAt(size - 1);
            this.pointerBack++;
            this.deque.Insert(this.pointerBack, default(T));
            
            return dequeuedElement;
        }

        internal void printDeque()
        {
            // 5 2 17 8 14 101 73 7 30 13
            Console.WriteLine(this.deque);
        }

    }
}
