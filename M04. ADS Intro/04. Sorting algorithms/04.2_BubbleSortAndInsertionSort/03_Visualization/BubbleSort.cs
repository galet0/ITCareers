using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BubbleSort
{
    public static class BubbleSort<T> where T : IComparable<T>
    {
        //0 1 2 3 4
        //5 4 3 2 1
        //4 5 3 2 1
        //4 3 5 2 1
        //4 3 2 5 1
        //4 3 2 1 5
        public static void Sort(T[] collection)
        {
            for (int j = 0; j < collection.Length; j++)
            {
                for (int i = 0; i < collection.Length-1; i++)
                {
                    if(Less(collection[i], collection[i + 1]))
                    {
                        Swap(collection, i, i+1);
                    }
                }
            }
        }

        private static bool Less<T>(T left, T right) where T :IComparable<T>
        {
            return right.CompareTo(left) < 0;
        }

        private static void Swap(T[] collection, int leftIndex, int rightIndex)
        {
            T temp = collection[rightIndex];
            Console.WriteLine($"Items to swap: index = [{rightIndex}] item = [{collection[leftIndex]}] with index = [{leftIndex}] item = [{collection[rightIndex]}]");

            collection[rightIndex] = collection[leftIndex];
            collection[leftIndex] = temp;

            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
