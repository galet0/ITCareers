using System;

namespace _365_Numberrom100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine($"{number} is Less than 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine($"{number} is Between 100 and 200");
            }
            else
            {
                Console.WriteLine($"{number} Greater than 200");
            }
        }
    }
}
