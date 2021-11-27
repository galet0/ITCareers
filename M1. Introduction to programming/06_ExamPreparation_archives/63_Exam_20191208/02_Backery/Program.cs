using System;

namespace _02_Backery
{
    class Program
    {
        static void Main(string[] args)
        {
            double pitkaPrice = double.Parse(Console.ReadLine());
            int pitkaQuantity = int.Parse(Console.ReadLine());
            int kozunakQuantity = int.Parse(Console.ReadLine());
            int gevrekQuantity = int.Parse(Console.ReadLine());
            int kroasanQuantity = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double kozunakPrice = pitkaPrice + pitkaPrice * 0.20;
            double gevrekPrice = kozunakPrice - kozunakPrice * 0.4;
            double kroasanPrice = gevrekPrice + 1.2;

            double total = pitkaPrice * pitkaQuantity
                        + kozunakPrice * kozunakQuantity
                        + gevrekPrice * gevrekQuantity
                        + kroasanPrice * kroasanQuantity;
            double diff = Math.Abs(budget - total);

            if(budget >= total)
            {
                Console.WriteLine($"Yes! {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2} leva need.");
            }
        }
    }
}
