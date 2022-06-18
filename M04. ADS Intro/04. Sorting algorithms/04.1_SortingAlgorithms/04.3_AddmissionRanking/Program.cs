using System;

namespace _04._3_AddmissionRanking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] admission = new int[] { 95, 98, 103, 109, 48, 92, 25, 106, 160 };

            SortDescending(admission);
            Console.WriteLine(string.Join(" ", admission));
        }

        private static void SortDescending(int[] collection)
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

        private static void Swap(int[] collection, int index, int min)
        {
            int temp = collection[index];
            collection[index] = collection[min];
            collection[min] = temp;
        }

        private static bool Less(int current, int min)
        {
            return current > min;
        }
    }
}
