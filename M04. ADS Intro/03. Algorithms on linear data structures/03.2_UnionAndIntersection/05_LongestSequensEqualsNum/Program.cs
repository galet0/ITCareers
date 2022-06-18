using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_LongestSequensEqualsNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 2 2 3 3 3
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currVal = list[0];
            int currCount = 1;
            int maxCount = 1;
            int maxValue = currVal;

            for (int i = 1; i < list.Count; i++)
            {
                if(currVal == list[i])
                {
                    currCount++;
                    if(currCount > maxCount)
                    {
                        maxCount = currCount;
                        maxValue = currVal;
                    }
                }
                else
                {
                    currCount = 1;
                    currVal = list[i];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxValue} ");
            }
        }
    }
}
