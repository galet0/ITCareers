using System;
using System.Linq;

namespace _123_SearchNumberInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int min = 0;
            int max = array.Length - 1;

            bool contains = false;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (number == array[mid])
                {
                    mid += 1;
                    contains = true;
                    break;
                }
                else if (number < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            if(contains)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
