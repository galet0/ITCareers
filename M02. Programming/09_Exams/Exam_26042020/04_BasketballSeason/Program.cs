using System;
using System.Collections.Generic;

namespace _04_BasketballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, int> players = new SortedDictionary<string, int>();

            while (input != "END")
            {
                string[] player = input.Split(" - ");

                if (!players.ContainsKey(player[0]))
                {
                    players.Add(player[0], 0);
                }
                players[player[0]] += int.Parse(player[1]);

                input = Console.ReadLine();
            }

            foreach (var item in players)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
