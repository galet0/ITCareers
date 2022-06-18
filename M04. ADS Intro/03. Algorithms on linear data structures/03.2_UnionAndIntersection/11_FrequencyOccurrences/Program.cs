using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_FrequencyOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            Dictionary<int, int> filter = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!filter.ContainsKey(list[i]))
                {
                    filter.Add(list[i], 0);
                }

                filter[list[i]]++;
            }

            foreach (var kvp in filter.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
