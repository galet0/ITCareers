using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SortingShortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch = ". , : ; ( ) [ ] \" \' \\ / ! ? ".ToCharArray();
            List<string> text = Console.ReadLine()
                .Split(ch, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.ToString().Length < 5)
                .OrderBy(w => w)
                .Select(w => w.ToLower())
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
