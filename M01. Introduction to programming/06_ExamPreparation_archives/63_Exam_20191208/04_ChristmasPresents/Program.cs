using System;

namespace _04_ChristmasPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int childrens = int.Parse(Console.ReadLine());
            double legosCount = 0;
            double monopolyCount = 0;
            double puzzlesCount = 0;
            double robotsCount = 0;

            for (int i = 0; i < childrens; i++)
            {
                string game = Console.ReadLine();
                if (game.Equals("lego"))
                {
                    legosCount++;
                }
                else if (game.Equals("monopoly"))
                {
                    monopolyCount++;
                }
                else if (game.Equals("puzzle"))
                {
                    puzzlesCount++;
                }
                else if (game.Equals("robot"))
                {
                    robotsCount++;
                }
            }

            Console.WriteLine($"Lego: {legosCount/childrens*100:f2}%");
            Console.WriteLine($"Monopoly: {monopolyCount/childrens*100:f2}%");
            Console.WriteLine($"Puzzles: {puzzlesCount/childrens*100:f2}%");
            Console.WriteLine($"Robots: {robotsCount/childrens*100:f2}%");
        }
    }
}
