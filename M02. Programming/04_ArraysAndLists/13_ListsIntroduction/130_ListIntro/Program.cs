using System;
using System.Collections.Generic;
using System.Linq;

namespace _130_ListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Peter");
            names.Add("Maria");
            names.Add("George");
            names.Add("Maria");
            names.Remove("Maria");
            names.RemoveAt(3);
            names.Insert(2, "Anna");
            Console.WriteLine(names[0]);

            Console.WriteLine(names.Contains("George"));
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello, {names[i]}!");
            }
            Console.WriteLine(string.Join(", ", names));
            //1 2 3 4 5 6
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        }
    }
}
