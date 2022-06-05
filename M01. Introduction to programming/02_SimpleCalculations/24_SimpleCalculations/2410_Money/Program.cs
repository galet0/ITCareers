using System;

namespace _2410_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int btc = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commissionInPercent = double.Parse(Console.ReadLine());

            double result = ((btc * 1168) + (yuan * 0.15 * 1.76)) / 1.95;//euro
            double commission = result * commissionInPercent / 100;

            result = result - commission;

            Console.WriteLine($"{result:f2}");
        }
    }
}
