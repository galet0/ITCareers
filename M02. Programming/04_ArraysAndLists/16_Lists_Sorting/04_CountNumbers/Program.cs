using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.Sort();
            //2 2 2 2 3 7 8 8

            int count = 1;
            int index = 0;
            int current = list[index];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == current)
                {
                    count++;
                }
                if(list[i] != current || i == list.Count-1)
                {
                    Console.WriteLine($"{list[index]} -> {count}");
                    count = 1;
                    index = i;
                    current = list[index];
                }
            }
        }
    }
}
