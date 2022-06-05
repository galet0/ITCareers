using System;
using System.Text;

namespace _01_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            string[] command = Console.ReadLine().Split();

            switch (command[0])
            {
                case "Append":
                    text.Append(command[1]);
                    break;
                case "Remove":
                    int pos = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    text.Remove(pos, count);
                    break;
                case "Insert":
                    text.Insert(int.Parse(command[1]), command[2]);
                    break;
                case "Replace":
                    text.Replace(command[1], command[2]);
                    break;
            }

            Console.WriteLine(text);
        }
    }
}
