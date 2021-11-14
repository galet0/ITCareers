using System;

namespace _499_EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int prevPairSum = 0;
            int maxPairDiff = 0;
            for (int i = 0; i < n; i++)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                if(i == 0)
                {
                    prevPairSum = first + second;
                }

                int currentPairSum = first + second;//2
                int diff = Math.Abs(currentPairSum - prevPairSum);

                if(diff > maxPairDiff)
                {
                    maxPairDiff = diff;
                }

                prevPairSum = currentPairSum;
            }

            if(maxPairDiff != 0)
            {
                Console.WriteLine($"No, maxdiff={maxPairDiff}");
            }
            else
            {
                Console.WriteLine($"Yes, value={prevPairSum}");
            }
        }
    }
}
