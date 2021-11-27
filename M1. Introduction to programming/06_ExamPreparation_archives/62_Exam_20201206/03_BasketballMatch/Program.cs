using System;

namespace _03_BasketballMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string sector = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double result = 0;

            switch (sector)
            {
                case "Sector A":
                    result = rows * cols * 11.60;
                    break;
                case "Sector B":
                    result = rows * cols * 14.50;
                    break;
                case "Sector C":
                    result = rows * cols * 16.10;
                    break;
                case "Sector D":
                    result = rows * cols * 8.40;
                    break;
            }

            Console.WriteLine($"{sector} profit is {result:f2} lv.");
        }
    }
}
