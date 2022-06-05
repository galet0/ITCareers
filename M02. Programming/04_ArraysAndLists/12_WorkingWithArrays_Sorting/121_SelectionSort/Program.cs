using System;

namespace _121_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 3, 1, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[k])
                        k = j;
                }
                int swapVar = arr[i];
                arr[i] = arr[k];
                arr[k] = swapVar;
            }

            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
