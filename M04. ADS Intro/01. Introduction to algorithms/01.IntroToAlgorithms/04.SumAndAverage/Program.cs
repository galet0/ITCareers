using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            double sum = Sum(list);
            double avg = sum / list.Count;

            Console.WriteLine($"Sum={sum}; Average={avg:f2}");
        }

        static double Sum(List<int> list)
        {
            double sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }


    }
}
