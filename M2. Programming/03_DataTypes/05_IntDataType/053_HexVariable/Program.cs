using System;

namespace _053_HexVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int decNumber = Convert.ToInt32(input, 16);
            Console.WriteLine(decNumber);
        }
    }
}
