using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1_SelectionSort
{
    public static class SelectionSort<T>
    {
        public static void Sort<T>(T[] collection) where T : IComparable<T>
        {
            for (int index = 0; index < collection.Length; index++)
            {
                int min = index;
                for (int curr = index + 1; curr < collection.Length; curr++)
                {
                    if (Less(collection[curr], collection[min]))
                    {
                        min = curr;
                    }
                }
                Swap(collection, index, min);
            }
        }
        private static void Swap<T>(T[] collection, int index, int min)
        {
            T temp = collection[index];
            Console.WriteLine($"Items to swap: index = [{index}] item = [{collection[index]}] with index = [{min}] item = [{collection[min]}]");
            collection[index] = collection[min];
            collection[min] = temp;
            Console.WriteLine(string.Join(" ", collection));
        }

        private static bool Less<T>(T current, T min) where T : IComparable<T>
        {
            return current.CompareTo(min) < 0;
        }
    }
}
