using System;

namespace _249_TilesRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            int landing = length * length;
            double tileArea = tileWidth * tileLength;
            int benchArea = benchLength * benchWidth;

            double tilesNeeded = (landing - benchArea) / tileArea;
            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine($"{tilesNeeded:f2}");
            Console.WriteLine($"{timeNeeded:f2}");
        }
    }
}
