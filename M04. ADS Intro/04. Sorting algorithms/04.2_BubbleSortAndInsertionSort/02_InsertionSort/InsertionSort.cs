using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InsertionSort
{
    public static class InsertionSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] collection)
        {
            //0 1 2 3 4
            //6 4 3 5 2
            for (int i = 1; i < collection.Length; ++i)
            {
                T key = collection[i];
                int prev = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (prev >= 0 && Less(collection[prev], key))
                {
                    collection[prev + 1] = collection[prev];
                    prev = prev - 1;
                }
                collection[prev + 1] = key;
            }
        }

        private static bool Less<T>(T left, T right) where T : IComparable<T>
        {
            return right.CompareTo(left) < 0;
        }

        private static void Swap(T[] collection, int leftIndex, int rightIndex)
        {
            T temp = collection[rightIndex];
            collection[rightIndex] = collection[leftIndex];
            collection[leftIndex] = temp;
        }
    }
}
