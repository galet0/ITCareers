using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._3_CircularQueue
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 8;
        private int startIndex;
        private int endIndex;

        private T[] elements;
        public int Count { get; private set; }
        public CircularQueue(int capacity = DefaultCapacity) 
        {
            this.elements = new T[capacity];
            this.startIndex = 4;
            this.endIndex = startIndex;
        }

        public void Enqueue(T element) 
        {
            if(this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            return this.elements[this.startIndex];
        }
        private void Grow()
        {
            T[] copy = new T[2 * this.elements.Length];
            this.CopyElements(copy);
            this.elements = copy;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private void CopyElements(T[] copy)
        {
            int sourceIndex = startIndex;

            for (int destinationIndex = 0; destinationIndex < this.Count; destinationIndex++)
            {
                copy[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
            }
        }
        public T Dequeue() 
        {
            T removed = this.Peek();
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            T[] copy = new T[this.elements.Length];
            this.CopyElements(copy);
            this.elements = copy;
            this.startIndex = 0;
            this.Count--;
            return removed;
        }

        public T[] ToArray() 
        {
            T[] array = new T[this.Count];
            CopyElements(array);
            return array;
        }

    }
}
