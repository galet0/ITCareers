using System;

namespace _01_FirstAndReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Team team = new Team("The Best team");

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                Person person = new Person(line[0], line[1], int.Parse(line[2]), double.Parse(line[3]));

                team.AddPlayer(person);
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
        }
    }
}
