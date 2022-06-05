using System;

namespace _101_OutputArrayWithForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join("; ", arr));
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
