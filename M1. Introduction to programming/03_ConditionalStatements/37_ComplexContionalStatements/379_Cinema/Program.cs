using System;

namespace _379_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double profit = 0;

            if (projectionType.Equals("Premiere"))
            {
                profit = rows * cols * 12;
            }
            else if (projectionType.Equals("Normal"))
            {
                profit = rows * cols * 7.5;
            }
            else if (projectionType.Equals("Discount"))
            {
                profit = rows * cols * 5;
            }

            Console.WriteLine($"{profit:f2} leva");
        }
    }
}
