using System;

namespace _101_ArrayOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "one", "two", "three", "four", "five" };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
