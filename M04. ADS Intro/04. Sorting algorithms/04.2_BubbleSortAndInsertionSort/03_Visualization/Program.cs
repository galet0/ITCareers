using _01_BubbleSort;
using _02_InsertionSort;
using System;

namespace _03_Visualization
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 3, 8, 1, 9, 2 };
            Console.WriteLine(new string('#', 5) + " BubbleSort " + new string('#', 5));
            BubbleSort<int>.Sort(nums);
            Console.WriteLine();

            int[] array = new int[] { 5, 3, 8, 1, 9, 2 };
            Console.WriteLine(new string('#', 5) + " InsertionSort " + new string('#', 5));
            InsertionSort<int>.Sort(array);
        }
    }
}
