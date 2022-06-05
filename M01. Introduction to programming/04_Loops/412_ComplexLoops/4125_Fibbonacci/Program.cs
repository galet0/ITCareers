using System;

namespace _4125_Fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long f0 = 1;
            long f1 = 1;

            for (int i = 0; i < n - 1; i++)
            {
                long fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }

            Console.WriteLine(f1);
        }
    }
}
