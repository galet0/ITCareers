using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                input[i] = new string(input[i].Reverse().ToArray());
            }

            //int sum = input.Select(int.Parse).Sum();
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum += int.Parse(input[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
