using System;

namespace _055_DecToHexAndBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(number, 16);
            string bin = Convert.ToString(number, 2);
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(bin);
        }
    }
}
