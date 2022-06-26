using System;
using System.Collections.Generic;

namespace _02_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //int[] nums = new int[] { 1, 4, 3, 8, 5, 6, 7, 8, 9};

            Console.WriteLine(BinarySearchRecursion(numbers, 3, 0, numbers.Length));
            Console.WriteLine(BinarySearchIteration(numbers, 3, 0, numbers.Length));
        }

        //with recursion
        private static int BinarySearchRecursion(int[] arr, int key, int start, int end)
        {
            if (end < start)
                return -1;
            else
            {
                // 0  1  2  3  4  5  6  7  8
                // 1, 2, 3, 4, 5, 6, 7, 8, 9

                int mid = (start + end) / 2;
                if (arr[mid] > key)
                    return BinarySearchRecursion(arr, key, start, mid - 1);
                else if (arr[mid] < key)
                    return BinarySearchRecursion(arr, key, mid + 1, end);
                else
                    return mid;
            }
        }

        //with iteration
        private static int BinarySearchIteration(int[] arr, int key, int start, int end)
        {
            while (end >= start)
            {
                //0  1  2  3  4  5  6  7  8
                //1, 4, 3, 8, 5, 6, 7, 8, 9

                int mid = (start + end) / 2;
                if (arr[mid] < key)
                    start = mid + 1;
                else if (arr[mid] > key)
                    end = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
