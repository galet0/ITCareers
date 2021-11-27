using System;

namespace _04_TennisWorldCup
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournirsCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double currentPoints = 0;
            double wons = 0;

            for (int i = 0; i < tournirsCount; i++)
            {
                string tournir = Console.ReadLine();

                if (tournir.Equals("W"))
                {
                    currentPoints += 2000;
                    wons++;
                }
                else if (tournir.Equals("F"))
                {
                    currentPoints += 1200;
                }
                else if (tournir.Equals("SF"))
                {
                    currentPoints += 720;
                }
            }

            Console.WriteLine($"Final points: {startPoints + currentPoints}");
            Console.WriteLine($"Average points: {Math.Floor(currentPoints / tournirsCount)}");
            Console.WriteLine($"{wons/tournirsCount*100:f2}%");
        }
    }
}
