using System;

namespace _1_FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasKG = double.Parse(Console.ReadLine());
            double orangesKG = double.Parse(Console.ReadLine());
            double raspberriesKG = double.Parse(Console.ReadLine());
            double strawberryKG = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberryPrice / 2;
            double orangesPrice = raspberriesPrice - raspberriesPrice * 0.4;
            double bananasPrice = raspberriesPrice - raspberriesPrice * 0.8;

            double totalAmount = strawberryPrice * strawberryKG
                                + raspberriesPrice * raspberriesKG
                                + orangesPrice * orangesKG
                                + bananasPrice * bananasKG;

            Console.WriteLine($"{totalAmount:f2}");

        }
    }
}
