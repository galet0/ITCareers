using System;

namespace _03_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 52, 96, 67, 71, 42, 38, 39, 40, 14 };

            int[] sorted = SortArray(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(" ", sorted));
        }

        public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);
            return array;
        }
    }
}
