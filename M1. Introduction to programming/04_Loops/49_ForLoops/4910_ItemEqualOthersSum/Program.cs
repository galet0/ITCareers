using System;

namespace _4910_ItemEqualOthersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = int.Parse(Console.ReadLine());

            int max = current;
            int sum = current;
            for (int i = 0; i < n-1; i++)
            {
                current = int.Parse(Console.ReadLine());
                sum += current;

                if(current > max)
                {
                    max = current;
                }
            }

            bool areEquals = (sum - max) == max;
            int sumOthers = sum - max;
            int diff = Math.Abs(sumOthers - max);

            if(areEquals)
            {
                Console.WriteLine($"Yes, Sum = {max}");
            }
            else
            {
                Console.WriteLine($"No, Diff = {diff}");
            }
        }
    }
}
