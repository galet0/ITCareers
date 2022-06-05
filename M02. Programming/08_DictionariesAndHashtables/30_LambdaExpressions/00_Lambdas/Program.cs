using System;
using System.Linq;

namespace _00_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            Func<int, bool> isEven = x => x % 2 == 0;
            int[] filtered = nums.Where(isEven).ToArray();

            Console.WriteLine(string.Join(" ", filtered));

            int countEvens = nums.Count(isEven);
            Console.WriteLine(countEvens);

            int countNumbers = nums.Count();
            Console.WriteLine(countNumbers);

            int[] arr = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };

            int[] a = arr.OrderBy(n => n).Take(3).ToArray();            
            Console.WriteLine(string.Join(" ", a));

            int[] b = arr.Where(x => x < 50).ToArray();
            Console.WriteLine(string.Join(" ", b));

            int countOdds = arr.Count(x => x % 2 != 0);
            Console.WriteLine(countOdds);

            int[] c = arr.Select(x => x * 2).Take(5).ToArray();
            Console.WriteLine(string.Join(" ", c));

            int[] numbers = { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };

            int[] d = numbers.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", d));

            int firstEven = numbers.FirstOrDefault(x => x % 2 == 0);
            Console.WriteLine(firstEven);
            int lastOdd = numbers.LastOrDefault(x => x % 2 != 0);
            Console.WriteLine(lastOdd);

            int single = numbers.SingleOrDefault(x => x < 0);
            Console.WriteLine(single);

            int[] reversed = numbers.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", reversed));
        }


    }
}
