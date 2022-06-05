using System;

namespace _494_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
            }

            Console.WriteLine(sum);
        }
    }
}
