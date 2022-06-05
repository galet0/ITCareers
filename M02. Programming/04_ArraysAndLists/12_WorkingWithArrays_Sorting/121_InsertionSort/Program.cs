using System;

namespace _121_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 1, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                int swapVar = arr[i];
                int index = i;
                while (index > 0 && arr[index - 1] >= swapVar)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = swapVar;

            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
