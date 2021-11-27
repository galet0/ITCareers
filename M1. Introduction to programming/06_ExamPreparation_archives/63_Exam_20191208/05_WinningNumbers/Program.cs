using System;

namespace _05_WinningNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int winners = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b<= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if(a+b == n && c % 2 == 0 && (d == 3 || d == 6))
                            {
                                winners++;
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Count of winner numbers: {winners}");
        }
    }
}
