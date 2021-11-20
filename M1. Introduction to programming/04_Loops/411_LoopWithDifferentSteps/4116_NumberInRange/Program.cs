using System;

namespace _4116_NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in range [1..100]");
            int number = int.Parse(Console.ReadLine());

            //[1..100]
            while (!(number > 1 && number <= 100))// number < 1 || number > 100
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(number);
        }
    }
}
