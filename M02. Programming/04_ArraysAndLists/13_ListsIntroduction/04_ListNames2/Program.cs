using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ListNames2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ivan Dimitrov, Maria Ivanova, Dimitar Petrov
            List<string> names = Console.ReadLine().Split(",").ToList();
            //Ivan Dimitrov
            // Maria Ivanova
            // Dimitar Petrov
            List<string> reversed = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                string[]  currentName = names[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                reversed.Add(new string(currentName[0] + " " + currentName[1]));
            }

            Console.WriteLine(string.Join(Environment.NewLine, reversed));
        }
    }
}
