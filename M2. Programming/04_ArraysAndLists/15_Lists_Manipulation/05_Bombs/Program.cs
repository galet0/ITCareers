using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 1 2 3 4 5 6 7
            //1 2 2 4 2 2 2 9
            //4 2
            //1 4 4 2 8 9 1
            //9 3
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombInfo = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bomb = bombInfo[0];
            int strenght = bombInfo[1];
            var newList = new List<int>();

            while (input.Contains(bomb))
            {
                int startIndex = input.IndexOf(bomb) - strenght; //1
                int detonation = strenght * 2 + 1; //
                newList = input.Skip(startIndex).Take(detonation).ToList();

                input.RemoveRange(startIndex, newList.Count);
            }

            Console.WriteLine(input.Sum());
        }
    }
}
