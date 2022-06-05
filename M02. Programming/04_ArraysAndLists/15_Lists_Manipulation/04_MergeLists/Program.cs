using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();
            //1 2 3 |4 5 6 |  7  8

            List<string> result = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                result.Add(string.Join(" ", list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
