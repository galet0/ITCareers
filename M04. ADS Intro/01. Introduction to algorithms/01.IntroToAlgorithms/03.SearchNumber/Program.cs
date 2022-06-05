using System;

namespace _03.SearchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
            int x = 110;

            Console.WriteLine(BinarySearch(array, 0, array.Length, x));

            Console.WriteLine(LinearSearch(array, x));
        }

        static int BinarySearch(int[] arr, int start, int end, int x)
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return BinarySearch(arr, start, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return BinarySearch(arr, mid + 1, end, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }

        public static int LinearSearch(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
