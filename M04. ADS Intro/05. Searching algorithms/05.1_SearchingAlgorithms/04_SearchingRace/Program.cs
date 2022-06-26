using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _04_SearchingRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100000000;
            int key = 4578965;
            int index = 0;

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }


            Console.WriteLine("1. Linear Search");
            MeasureTime(() => index = Search<int>.LinearSearch(list, key));
            Console.WriteLine(index == -1 ? false : true);

            Console.WriteLine("2. Binary Search Recursion");
            MeasureTime(() => index = Search<int>.BinarySearchRecursion<int>(list, key, 0, list.Count - 1));
            Console.WriteLine(index == -1 ? false : true);

            Console.WriteLine("3. Binary Search Iteration");
            MeasureTime(() => index = Search<int>.BinarySearchIteration<int>(list, key, 0, list.Count - 1));
            Console.WriteLine(index == -1 ? false : true);

            Console.WriteLine("4. Fibonacci Search");
            MeasureTime(() => index = Search<int>.FibonacciSearch<int>(list, key, list[list.Count - 1]));
            Console.WriteLine(index == -1 ? false : true);

            Console.WriteLine("5. Interpolation Search");
            MeasureTime(() => index = Search<int>.InterpolationSearch(list, key));
            Console.WriteLine(index == -1 ? false : true);
        }

        private static void MeasureTime(Action method)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            method();

            timer.Stop();
            Console.WriteLine($"Time = {timer.ElapsedTicks} ticks {timer.ElapsedMilliseconds}ms ");
        }
    }
}
