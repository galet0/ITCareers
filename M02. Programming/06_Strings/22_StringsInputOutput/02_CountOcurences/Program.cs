using System;

namespace _02_CountOcurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            //ababa caba
            //aba
            int index = 0;
            int counter = 0;
            while (index != -1)
            {
                index = input.IndexOf(pattern, index + 1);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
