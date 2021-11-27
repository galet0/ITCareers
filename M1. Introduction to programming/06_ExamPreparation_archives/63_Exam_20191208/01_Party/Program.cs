using System;

namespace _01_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());

            double pizza = 2 * price;
            double drinks = pizza - pizza * 0.15;
            double games = (pizza + drinks) / 7;

            double total = price + pizza + drinks + games;

            Console.WriteLine($"{total:f2}");
        }
    }
}
