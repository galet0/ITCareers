using System;

namespace _98_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            long totalSum = 0;

            if(firstNum >= 0 && firstNum <= 127)
            {
                totalSum += 4 * firstNum;
            }
            else
            {
                totalSum += 10 * firstNum;
            }

            if(secondNum >= 0 && secondNum <= 127)
            {
                totalSum += 4 * secondNum;
            }
            else
            {
                totalSum += 10 * secondNum;
            }

            Console.WriteLine(totalSum);
        }
    }
}
