using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SearchingRace
{
    public static class Search<T>
    {
        public static int LinearSearch(List<T> list, T item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearchRecursion<T>(List<T> list, T key, int start, int end) where T : IComparable<T>
        {
            if (end < start)
                return -1;
            else
            {
                // 0  1  2  3  4  5  6  7  8
                // 1, 2, 3, 4, 5, 6, 7, 8, 9

                int mid = (start + end) / 2;
                if (list[mid].CompareTo(key) > 0)
                    return BinarySearchRecursion(list, key, start, mid - 1);
                else if (list[mid].CompareTo(key) < 0)
                    return BinarySearchRecursion(list, key, mid + 1, end);
                else
                    return mid;
            }
        }

        //with iteration
        public static int BinarySearchIteration<T>(List<T> list, T key, int start, int end) where T : IComparable<T>
        {
            while (end >= start)
            {
                //0  1  2  3  4  5  6  7  8
                //1, 4, 3, 8, 5, 6, 7, 8, 9

                int mid = (start + end) / 2;
                if (list[mid].CompareTo(key) < 0)
                    start = mid + 1;
                else if (list[mid].CompareTo(key) > 0)
                    end = mid - 1;
                else
                    return mid;
            }
            return -1;
        }

        private static int min(int x, int y)
        {
            return (x <= y) ? x : y;
        }

        /* Returns index of x if present, else returns -1 */
        public static int FibonacciSearch<T>(List<T> list, T x, int n) where T : IComparable<T>
        {
            /* Initialize fibonacci numbers */
            int fibMMm2 = 0; // (m-2)'th Fibonacci No.
            int fibMMm1 = 1; // (m-1)'th Fibonacci No.
            int fibM = fibMMm2 + fibMMm1; // m'th Fibonacci

            /* fibM is going to store the smallest
            Fibonacci Number greater than or equal to n */
            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }

            // Marks the eliminated range from front
            int offset = -1;

            /* while there are elements to be inspected.
            Note that we compare arr[fibMm2] with x.
            When fibM becomes 1, fibMm2 becomes 0 */
            while (fibM > 1)
            {
                // Check if fibMm2 is a valid location
                int i = min(offset + fibMMm2, n - 1);

                /* If x is greater than the value at
                index fibMm2, cut the subarray array
                from offset to i */
                if (list[i].CompareTo(x) < 0)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }

                /* If x is less than the value at index
                fibMm2, cut the subarray after i+1 */
                else if (list[i].CompareTo(x) > 0)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }

                /* element found. return index */
                else
                    return i;
            }

            /* comparing the last element with x */
            if (fibMMm1 == 1 && list[n - 1].Equals(x))
                return n - 1;

            /*element not found. return -1 */
            return -1;
        }

        public static int InterpolationSearch(List<int> list, int key)
        {
            int low = 0;
            int high = list.Count - 1;
            while (list[low] <= key && list[high] >= key)
            {
                //0  1  2  3  4  5  6  7  8
                //1, 2, 3, 4, 5, 6, 7, 8, 9
                //pos = lo + (((hi - lo) / (arr[hi] - arr[lo])) * (x - arr[lo]));

                //int mid = low + ((key - list[low]) * (high - low)) / (list[high] - list[low]); //0 + (6 - 1) * (8 - 0) / (9 - 1)
                int mid = low + (((high - low) / (list[high] - list[low])) * (key - list[low]));
                if (list[mid] < key)
                    low = mid + 1;
                else if (list[mid] > key)
                    high = mid - 1;
                else
                    return mid;
            }
            if (list[low] == key) return low;
            else return -1;
        }
    }
}
