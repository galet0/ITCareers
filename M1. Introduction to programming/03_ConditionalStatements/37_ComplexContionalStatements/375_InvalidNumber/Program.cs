using System;

namespace _375_InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var isInRange = (number >= 100 && number <= 200) || number == 0;

            if (!isInRange)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
