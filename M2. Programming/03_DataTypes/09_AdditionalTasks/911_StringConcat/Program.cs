using System;

namespace _911_StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string row = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string concat = null;

            for (int i = 1; i <= n; i++)
            {
                string line = Console.ReadLine();

                if (row.Equals("odd") && i % 2 != 0)
                {
                    concat += line + symbol;
                }
                else if(row.Equals("even") && i % 2 == 0)
                {
                    concat += line + symbol;
                }
            }
            Console.WriteLine(concat);
            Console.WriteLine("length: " + concat.Length);
            Console.WriteLine("last index: " + concat.LastIndexOf('-'));
            concat = concat.Remove(concat.Length - 1);
            Console.WriteLine(concat);
        }
    }
}
