using System;
using System.Collections.Generic;
using System.Linq;

namespace _160_SortList_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Nakov", "Angel", "Ivan", "Atanas", "Boris" };

            //names.Sort();
            //names.Reverse();
            names = names.OrderByDescending(n => n).ToList();
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
