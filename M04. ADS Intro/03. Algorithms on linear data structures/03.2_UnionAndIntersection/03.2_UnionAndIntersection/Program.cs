using System;
using System.Collections.Generic;

namespace _03._2_UnionAndIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5};
            List<int> secondList = new List<int> { 2, 4, 6 };

            List<int> union = Union(firstList, secondList);
            Console.WriteLine(string.Join(", ", union));

            List<int> intersect = Intersect(firstList, secondList);
            Console.WriteLine(string.Join(", ", intersect));
        }

        public static List<int> Union(List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);

            foreach (var item in secondList)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }

        public static List<int> Intersect(List<int> firstList, List<int> secondList)
        {
            List<int> intersect = new List<int>();
            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersect.Add(item);
                }
            }
            return intersect;
        }

        public static List<int> Union2(List<int> firstList, List<int> secondList)
        {
            List<int> unionList = new List<int>();
            unionList.AddRange(firstList);
            for (int i = unionList.Count - 1; i >= 0; i--)
            {
                if (secondList.Contains(unionList[i]))
                {
                    unionList.RemoveAt(i);
                }
            }

            unionList.AddRange(secondList);
            return unionList;
        }

        public static List<int> Intersect2(List<int> firstList, List<int> secondList)
        {
            List<int> intersectList = new List<int>();
            intersectList.AddRange(firstList);

            for (int i = intersectList.Count - 1; i >= 0; i--)
            {
                if (!secondList.Contains(intersectList[i]))
                {
                    intersectList.RemoveAt(i);
                }
            }

            return intersectList;
        }
    }
}
