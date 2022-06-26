using System;

namespace _03_InterpolationSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(InterpolationSearch(nums, 2));

        }

        private static int InterpolationSearch(int[] sortedArray, int key)
        {
            int low = 0;
            int high = sortedArray.Length - 1;
            while (sortedArray[low] <= key && sortedArray[high] >= key)
            {
                //0  1  2  3  4  5  6  7  8
                //1, 2, 3, 4, 5, 6, 7, 8, 9
                int mid = low + ((key - sortedArray[low]) * (high - low))
                  / (sortedArray[high] - sortedArray[low]); //0 + (6 - 1) * (8 - 0) / (9 - 1)
                if (sortedArray[mid] < key)
                    low = mid + 1;
                else if (sortedArray[mid] > key)
                    high = mid - 1;
                else
                    return mid;
            }
            if (sortedArray[low] == key) return low;
            else return -1;
        }

    }
}
