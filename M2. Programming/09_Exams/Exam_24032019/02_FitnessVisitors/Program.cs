using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_FitnessVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();
            string newVisitor = "";
            int position = 0;
            while (command != "END")
            {
                switch (command)
                {
                    case "Add visitor":
                        newVisitor = Console.ReadLine();
                        visitors.Add(newVisitor);
                        break;
                    case "Add visitor on position":
                        newVisitor = Console.ReadLine();
                        position = int.Parse(Console.ReadLine());
                        visitors.Insert(position, newVisitor);
                        break;
                    case "Remove visitor on position":
                        position = int.Parse(Console.ReadLine());
                        visitors.RemoveAt(position);
                        break;
                    case "Remove last visitor":
                        visitors.RemoveAt(visitors.Count - 1);
                        break;
                    case "Remove first visitor":
                        visitors.RemoveAt(0);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", visitors));
        }
    }
}
