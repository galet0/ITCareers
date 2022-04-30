using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			var names = Console.ReadLine().Split(',').ToList();
			string command = Console.ReadLine();
			bool m = true;
			//if (command == "END OF PATIENTS") ;
			while (true)
			{
				if (command == "END OF PATIENTS")
				{
					break;
				}
				switch (command)
				{
					case "Add patient":
						string name2 = Console.ReadLine(); names.Add(name2); break;
					case "Add patient on position":
						name2 = Console.ReadLine();
						int num = int.Parse(Console.ReadLine());
						names.Insert(num, name2);
						break;
					case "Remove patient on position":
						num = int.Parse(Console.ReadLine());
						names.RemoveAt(num);
						break;
					case "Remove last patient": names.RemoveAt(names.Count - 1); break;
					case "Remove first patient": names.RemoveAt(0); break;
				}
			}
			Console.WriteLine(String.Join(" ", names));
		}
    }
}
