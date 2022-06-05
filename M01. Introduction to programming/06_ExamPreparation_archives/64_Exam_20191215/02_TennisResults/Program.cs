using System;

namespace _02_TennisResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int wonGames = 0;
            int lostGames = 0;

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(":");

                int grigor = int.Parse(input[0]);
                int other = int.Parse(input[1]);

                if(grigor > other)
                {
                    wonGames++;
                }
                else
                {
                    lostGames++;
                }
            }

            Console.WriteLine($"Grigor won {wonGames} games.");
            Console.WriteLine($"Grigor lost {lostGames} games.");
        }
    }
}
