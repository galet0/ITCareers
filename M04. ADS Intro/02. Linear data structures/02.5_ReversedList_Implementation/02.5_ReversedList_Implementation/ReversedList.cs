using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._5_ReversedList_Implementation
{
    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] items;
        private const int InitialCapacity = 2;
        public int Count { get; private set; }
        public int Capacity { get => this.items.Length; }
        public ReversedList(int capacity = InitialCapacity)
        {
            this.items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                this.CheckIndex(index);
                return this.items[this.Count-1 - index];
            }
            set
            {
                this.CheckIndex(index);
                this.items[this.Count - 1 - index] = value;
            }
        }

        private void CheckIndex(int index)
        {
            if(index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Add(T item)
        {
            if(this.Count >= this.items.Length)
            {
                this.Grow();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            CheckIndex(index);
            T removed = this[index];

            for (int i = 0; i < this.Count; i++)
            {
                if(index == this.Count - 1 - i)
                {
                    this[index] = default;
                    break;
                }
            }

            for (int i = this.Count - 1 - index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.Count--;
            return removed;
        }

        private void Grow()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0 ; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
