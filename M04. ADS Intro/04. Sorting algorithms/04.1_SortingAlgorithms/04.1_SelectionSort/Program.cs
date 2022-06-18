using System;

namespace _04._1_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 3, 8, 1, 10, 4 };

            char[] chars = new char[] { 'x', 'e', 'a', 'z', 'h' };

            string[] strings = new string[] { "aaa", "vv", "bbb", "hgf", "qwer" };

            SelectionSort<int>.Sort(array);
            SelectionSort<char>.Sort(chars);
            SelectionSort<string>.Sort(strings);

            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(string.Join(", ", chars));
            Console.WriteLine(string.Join(", ", strings));
        }
    }
}
