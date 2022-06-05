using System;

namespace _01_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            double distance = 384400;

            double totalDistance = distance * 2;
            double hours = Math.Ceiling(totalDistance / speed) + 3;
            double totalFuel = totalDistance * fuel / 100;

            Console.WriteLine(hours);
            Console.WriteLine(totalFuel);
        }
    }
}
