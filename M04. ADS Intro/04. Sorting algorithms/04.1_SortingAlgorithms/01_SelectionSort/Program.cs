using System;

namespace _01_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = new int[] { 95, 12, 78, 4, 1, 45, 16, 23, 8, 12, 4, 45, 16, 18, 54 };

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

            Console.WriteLine(string.Join(", ", collection));
        }

        private static void Swap(int[] collection, int index, int min)
        {
            int temp = collection[index];
            collection[index] = collection[min];
            collection[min] = temp;
        }

        private static bool Less(int current, int min)
        {
            return current < min;
        }
    }
}
