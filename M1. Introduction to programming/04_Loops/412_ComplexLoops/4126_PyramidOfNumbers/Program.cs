using System;

namespace _4126_PyramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{++num} ");
                    if (num >= n)
                    {
                        break;
                    }
                }
                if (num >= n)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
