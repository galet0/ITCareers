using System;

namespace _121_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 3, 1, 10 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    //0  1   2  3   4
                    //2, 3,  4, 1, 10
                    if (arr[j] > arr[j + 1])
                    {
                        int swapVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
