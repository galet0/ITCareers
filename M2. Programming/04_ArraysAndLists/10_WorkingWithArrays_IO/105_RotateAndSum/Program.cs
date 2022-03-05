using System;
using System.Linq;

namespace _105_RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];

            for (int i = 0; i < k; i++)
            {
                array = Rotate(array);//
                sum = Sum(array, sum);
                Console.WriteLine("rotated[] =  " + string.Join(" ", array));
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static int[] Sum(int[] array, int[] sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum[i] = array[i] + sum[i];
            }

            return sum;
        }

        private static int[] Rotate(int[] array)
        {
            var last = array.TakeLast(1).ToArray();
            var first = array.Take(array.Length - 1).ToArray();
            array = last.Concat(first).ToArray();
            return array;
        }
    }
}
