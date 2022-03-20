using System;
using System.Collections.Generic;

namespace _01_ListInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {numbers[i]}");
            }
        }
    }
}
