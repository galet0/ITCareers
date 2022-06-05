using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StaticList
{
    public class CustomArrayList<T> where T : IComparable<T>
    {
		private T[] arr;

		private int count;

		public int Count
		{
			get
			{
				return count;
			}
		}

		private static readonly int INITIAL_CAPACITY = 4;

		public CustomArrayList()
		{
			arr = new T[INITIAL_CAPACITY];
			count = 0;
		}
		public void Add(T item)
		{
			if(this.Count == this.arr.Length)
            {
				this.Resize();
            }
			this.arr[this.Count] = item;
			this.count++;
		}

        private void Resize()
        {
			T[] copy = new T[this.arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
            {
				copy[i] = arr[i];
            }

			arr = copy;
        }

        public void Insert(int index, T item)
		{
			T[] newArr = new T[arr.Length + 1];

            for (int i = 0; i < index; i++)
            {
				newArr[i] = arr[i];
            }

			newArr[index] = item;

            for (int i = index + 1; i < newArr.Length; i++)
            {
				newArr[i] = arr[i - 1];
            }

			this.count++;
			arr = newArr;
		}

		public int IndexOf(T item)
		{
            for (int i = 0; i < this.Count; i++)
            {
				if(this.arr[i].CompareTo(item) == 0)
                {
					return i;
                }
            }

			return -1;
		}

		public void Clear()
		{
			this.arr = new T[INITIAL_CAPACITY];
			this.count = 0;
		}

		public bool Contains(T item)
		{
			return this.IndexOf(item) != -1 ? true : false;
		}

		public T this[int index]
		{
            get
            {
				CheckIndex(index);
				return this.arr[index];
            }

            set
            {
				CheckIndex(index);
				this.arr[index] = value;
            }
		}

		private void CheckIndex(int index)
        {
			if(index < 0 || index >= this.count)
            {
				throw new ArgumentOutOfRangeException();
            }
        }
		public T RemoveAt(int index)
		{
			CheckIndex(index);
			T removed = this.arr[index];

            for (int i = index; i < this.Count; i++)
            {
				arr[i] = arr[i + 1];
            }
			this.count--;
			return removed;
		}

		public int Remove(T item)
		{
			int index = this.IndexOf(item);
			if(index != -1)
            {
				this.RemoveAt(index);
            }

			return index;
		}

	}
}
