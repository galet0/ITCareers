using System;

namespace _384_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            int wineLittersNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrape = vineyard * grape;
            double wine = (totalGrape * 0.4) / 2.5;
            double diff = Math.Abs(wineLittersNeeded - wine);

            if(wine < wineLittersNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(diff / workers)} liters per person.");
            }

        }
    }
}
