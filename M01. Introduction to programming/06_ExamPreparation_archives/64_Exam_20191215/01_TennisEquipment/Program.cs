using System;

namespace _01_TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int tennisRacketCount = int.Parse(Console.ReadLine());
            int shoesCount = int.Parse(Console.ReadLine());

            double totalTenisRacket = tennisRacketPrice * tennisRacketCount;
            double shoesTotal = shoesCount * (tennisRacketPrice / 6);
            double otherEquipment = (totalTenisRacket + shoesTotal) * 0.2;

            double totalSum = totalTenisRacket + shoesTotal + otherEquipment;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalSum/8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(7*totalSum/8)}");
        }
    }
}
