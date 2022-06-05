using System;
using System.Collections.Generic;

namespace _03_MiningTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //gold 155 + 15
            //silver 75 + 25
            Dictionary<string, int> fossils = new Dictionary<string, int>();

            while (true)
            {
                string fossil = Console.ReadLine();
                if (fossil == "stop") break;

                int quantity = int.Parse(Console.ReadLine());

                if (!fossils.ContainsKey(fossil))
                {
                    fossils.Add(fossil, 0);
                }
                fossils[fossil] += quantity;
            }

            foreach (var f in fossils)
            {
                Console.WriteLine($"{f.Key} -> {f.Value}");
            }
        }
    }
}
