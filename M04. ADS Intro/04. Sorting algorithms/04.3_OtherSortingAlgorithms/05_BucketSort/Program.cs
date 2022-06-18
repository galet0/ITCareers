using System;
using System.Collections.Generic;

namespace _05_BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 43, 17, 87, 92, 31, 6, 96, 13, 66, 62, 4 };

            Console.WriteLine("Bucket Sort");

            Console.WriteLine(string.Join(" ", array));

            List<int> sorted = BucketSort.Sort(array);

            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
