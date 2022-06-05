using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_FootballTeam
{
    class Program
    {
        static List<Team> teams = new List<Team>();
        static void Main(string[] args)
        {
            string[] teamInfo = Console.ReadLine().Split(";");
            string[] input = Console.ReadLine().Split(";");

            while (input[0] != "END")
            {
                try
                {
                    Team team = new Team(teamInfo[1]);
                    teams.Add(team);

                    Team searchedTeam = null;


                    switch (input[0])
                    {
                        case "Add":
                            bool result = AddPlayer(input.Skip(1).ToArray());
                            if (!result)
                            {
                                Console.WriteLine($"Team {input[1]} does not exists.");
                            }
                            break;
                        case "Remove":
                            searchedTeam = GetTeamByName(input[1]);
                            if (searchedTeam == null)
                            {
                                Console.WriteLine($"Team {input[1]} does not exists.");
                            }
                            else
                            {
                                if (!searchedTeam.RemovePlayer(input[2]))
                                {
                                    Console.WriteLine($"Player {input[2]} is not in {input[1]} team. ");
                                }
                            }
                            break;
                        case "Rating":
                            searchedTeam = GetTeamByName(input[1]);
                            if (searchedTeam == null)
                            {
                                Console.WriteLine($"Team {input[1]} does not exists.");
                            }
                            else
                            {
                                Console.WriteLine($"{searchedTeam.Name} - {searchedTeam.Rating()}");
                            }
                            break;
                    }

                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine().Split(";");
            }


        }
        static bool AddPlayer(string[] args)
        {
            Team team = GetTeamByName(args[0]);
            if (team != null)
            {
                Statistic stats = CreateStatistic(args.Skip(2).Select(int.Parse).ToArray());
                Player player = CreatePlayer(args[1], stats);

                team.AddPlayer(player);

                return true;
            }

            return false;
        }

        private static Player CreatePlayer(string name, Statistic stats)
        {
            return new Player(name, stats);
        }

        private static Statistic CreateStatistic(int[] args)
        {
            return new Statistic(args[0], args[1], args[2], args[3], args[4]);
        }

        static Team GetTeamByName(string name)
        {
            return teams.Where(t => t.Name == name).FirstOrDefault();
        }


    }
}
