using System;

namespace _4122_SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //2134
            int sum = 0;
            do
            {
                sum += number % 10; //sum = sum + number % 10
                number /= 10; //number = number / 10;
            } while (number > 0);

            Console.WriteLine(sum);
        }
    }
}
