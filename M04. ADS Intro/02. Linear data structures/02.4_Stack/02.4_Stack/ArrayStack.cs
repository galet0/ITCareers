using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._4_Stack
{
    public class ArrayStack<T> : IEnumerable<T> where T : IComparable<T>
    {
        private T[] elements;
        public int Count { get; private set; }

        private const int InitialCapacity = 4;
        public ArrayStack(int capacity = InitialCapacity) 
        {
            this.elements = new T[capacity];
        }
        public void Push(T element) 
        {
            if(this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

        private void Grow()
        {
            T[] newElements = new T[2 * this.elements.Length];
            this.CopyElements(newElements);
        }

        private void CopyElements(T[] newElements)
        {
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        public T Peek()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            return this.elements[this.Count-1];
        }
        public T Pop() 
        {
            T item = this.Peek();

            this.elements[this.Count - 1] = default;
            this.Count--;
            return item;
        }
        public T[] ToArray() 
        {
            T[] array = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                array[i] = this.elements[this.Count - 1 - i];
            }

            return array;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if(this.elements[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.elements = new T[InitialCapacity];
            this.Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            T[] array = this.ToArray();

            foreach (var item in array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
