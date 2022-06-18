using System;

namespace _02_OrderedPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(i != j)
                    {
                        Console.WriteLine($"{i} {j}");
                    }
                }
            }
        }
    }
}
