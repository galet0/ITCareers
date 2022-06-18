using System;

namespace _01_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 3, 8, 1, 9, 2 };

            string[] strings = new string[] { "asd", "tre", "osss", "zxc", "aaa", "ccc", "ggg" };

            char[] chars = new char[] { 'b', 'a', 'd', 'e', 'r' };

            BubbleSort<int>.Sort(nums);
            BubbleSort<string>.Sort(strings);
            BubbleSort<char>.Sort(chars);

            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(string.Join(" ", strings));
            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
