using System;
using System.Collections.Generic;

namespace _03_MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>() { 1, 2, 8, 10, 15, 20 };
            List<int> secondList = new List<int>() { 1, 2, 3, 4, 5, 6, 12, 13, 18 };
            List<int> mergedList = new List<int>();//1 1 2 2 
            mergedList.AddRange(firstList);
            int index = 0;

            //TO DO...
            //foreach (var n in secondList)
            //{
            //    if (mergedList.IndexOf(n) == -1)
            //    {
            //        mergedList.Insert(index, n);
            //    }

            //    index++;
            //}
        }
    }
}
