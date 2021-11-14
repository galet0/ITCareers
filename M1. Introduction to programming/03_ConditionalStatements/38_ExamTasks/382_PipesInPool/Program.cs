using System;

namespace _382_PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());//obem
            int P1 = int.Parse(Console.ReadLine());//debit 1
            int P2 = int.Parse(Console.ReadLine());//debit 2
            double H = double.Parse(Console.ReadLine());//hours

            double P1Fill = P1 * H;
            double P2Fill = P2 * H;
            double totalLittersFilled = P1Fill + P2Fill;

            double totalInPersent = totalLittersFilled / V * 100;
            double P1Percent = P1Fill / totalLittersFilled * 100;
            double P2Percent = P2Fill / totalLittersFilled * 100;

            if(totalLittersFilled <= V)
            {
                Console.WriteLine($"The pool is {(int)totalInPersent}% full. Pipe 1: {(int)P1Percent}%. Pipe 2: {(int)P2Percent}%.");
            }
            else
            {
                Console.WriteLine($"For {H} hours the pool overflows with {totalLittersFilled-V} liters.");
            }
        }
    }
}
