using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nums.Add(number);
            }

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Avg = {nums.Average()}");
            Console.WriteLine($"First = {nums.FirstOrDefault()}");
            Console.WriteLine($"Last = {nums.LastOrDefault()}");
        }
    }
}
