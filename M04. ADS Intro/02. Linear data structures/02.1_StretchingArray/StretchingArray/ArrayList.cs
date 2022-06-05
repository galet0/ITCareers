using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchingArray
{
    public class ArrayList<T>
    {
        private T[] items;
        private int initialCapacity = 2;
        private int count;

        public int Count => this.count;
        public ArrayList()
        {
            items = new T[initialCapacity];
        }
        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return this.items[index];
            }
            set
            {
                CheckIndex(index);
                this.items[index] = value;
            }
        }
        public void Add(T item)
        {
            if(this.count == items.Length)
            {
                Grow();
            }
            this.items[count] = item;
            this.count++;
        }

        public T RemoveAt(int index)
        {
            CheckIndex(index);
            T removed = this.items[index];
            Shift(index);
            this.count--;

            if(this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return removed;
        }
        private void CheckIndex(int index)
        {
            if(index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        private void Shrink()
        {
            T[] temp = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = this.items[i];
            }

            this.items = temp;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = items[i + 1];
            }
        }

        private void Grow()
        {
            initialCapacity *= 2;
            T[] temp = new T[initialCapacity];
            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }

            items = temp;
        }
    }
}
