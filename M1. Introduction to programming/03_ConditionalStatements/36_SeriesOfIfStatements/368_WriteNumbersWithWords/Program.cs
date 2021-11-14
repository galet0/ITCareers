using System;

namespace _368_WriteNumbersWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
                string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                int digit2 = number % 10;
                int digit1 = (number - digit2) / 10;

                if (number >= 0 && number <= 100)
                {
                    if (number == 100)
                    {
                        Console.WriteLine("one hundred");
                    }
                    else if (number <= 10)
                    {
                        Console.WriteLine(ones[number]);
                    }
                    else if (number < 20)
                    {
                        Console.WriteLine(teens[(number % 10) - 1]);
                    }
                    else if (number % 10 == 0)
                    {
                        Console.WriteLine(tens[number / 10 - 2]);
                    }
                    else if (number > 20)
                    {
                        Console.WriteLine(tens[digit1 - 2] + " " + ones[digit2]);
                    }
                }
                else
                {
                    Console.WriteLine("invalid number");
                }

            }
        }
    }
}
