using _04._1_SelectionSort;
using System;

namespace _04._2_VisualizationSelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 3, 8, 1, 10, 4 };

            char[] chars = new char[] { 'x', 'e', 'a', 'z', 'h' };

            string[] strings = new string[] { "aaa", "vv", "bbb", "hgf", "qwer" };

            Console.WriteLine(string.Join(", ", array));
            SelectionSort<int>.Sort(array);
            Console.WriteLine(new string('#', 30));

            Console.WriteLine(string.Join(", ", chars));
            SelectionSort<char>.Sort(chars);
            Console.WriteLine(new string('#', 30));

            Console.WriteLine(string.Join(", ", strings));
            SelectionSort<string>.Sort(strings);
            Console.WriteLine(new string('#', 30));

        }
    }
}
