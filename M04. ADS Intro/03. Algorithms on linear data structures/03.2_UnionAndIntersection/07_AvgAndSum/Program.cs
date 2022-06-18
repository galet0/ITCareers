using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AvgAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
            Console.WriteLine(sum/list.Count);
        }
    }
}
