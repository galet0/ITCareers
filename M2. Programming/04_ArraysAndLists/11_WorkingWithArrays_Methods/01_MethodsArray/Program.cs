using System;
using System.Linq;

namespace _01_MethodsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, -5, 1, 10 };

            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));

            Array.Sort(arr);
            //-5 1 2 4 10
            Console.WriteLine(string.Join(" ", arr));

            Array.Clear(arr, 0, 3);
            Console.WriteLine(string.Join(" ", arr));

            int[] source = new int[] { 1, 2, 3 };
            int[] destination = new int[] { 2, 4, -5, 1, 10 };
            source.CopyTo(destination, 1);
            Console.WriteLine(string.Join(" ", destination));

            int[] source1 = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] destination1 = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            Array.Copy(source1, 4, destination1, 2, 3);
            Console.WriteLine(string.Join(" ", destination1));

        }
    }
}
