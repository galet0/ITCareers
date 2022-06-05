using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int k = list.Count / 4;
            // 1 2 3 4 5 6 7 8
            List<int> upList = list.Take(k)
                                    .Reverse()
                                    .Concat(list.TakeLast(k).Reverse())
                                    .ToList();

            List<int> downList = list.Skip(k)
                                    .Take(2 * k).ToList();

            List<int> sumList = new List<int>();
            for (int i = 0; i < 2 * k; i++)
            {
                sumList.Add(upList[i] + downList[i]);
            }
            Console.WriteLine(string.Join(" ", sumList));
        }
    }
}
