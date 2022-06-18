using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>() { 1, 2, 8, 10, 15, 20, 23, 24, 27};
            List<int> secondList = new List<int>() { 1, 2, 3, 4, 5, 6, 12, 13, 18 };

            List<int> mergedList = MergeTwoSortedArray(firstList, secondList);

            Console.WriteLine(string.Join(" ", firstList));
            Console.WriteLine(string.Join(" ", secondList));
            Console.WriteLine(string.Join(" ", mergedList));
        }

        private static List<int> MergeTwoSortedArray(List<int> first, List<int> second)
        {
            List<int> result = new List<int>();

            int i = 0, j = 0, k = 0;

            while (result.Count <= (first.Count + second.Count))
            {
                //0  1  2   3   4   5
                //1, 2, 8, 10, 15, 20 

                //0  1  2  3  4  5   6   7   8
                //1, 2, 3, 4, 5, 6, 12, 13, 18
                if(j > second.Count-1)
                {
                    result.AddRange(first.Skip(i));
                    break;
                }
                else if(i > first.Count - 1)
                {
                    result.AddRange(second.Skip(j));
                    break;
                }
                else
                {
                    if (first[i] <= second[j])
                    {
                        result.Add(first[i++]);
                    }
                    else
                    {
                        result.Add(second[j++]);
                    }
                }
            }

            return result;
        }
    }
}
