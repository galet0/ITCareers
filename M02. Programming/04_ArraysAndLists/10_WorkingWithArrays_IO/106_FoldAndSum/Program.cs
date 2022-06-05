using System;
using System.Linq;

namespace _106_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = 4;

            int[] left = array.Take(array.Length / k).Reverse().ToArray();          
            int[] right = array.TakeLast(array.Length / k).Reverse().ToArray();

            int[] upper = left.Concat(right).ToArray();
            int[] middle = array.Skip(left.Length).Take((array.Length / k) * 2).ToArray();

            int[] sum = new int[array.Length / 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = upper[i] + middle[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
