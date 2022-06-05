using System;

namespace _5157_MultiplyEvenOddsDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            //12345

            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while(number > 0)
            {
                //123
                int currentDigit = number % 10;
                if(currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
                number = number / 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                //123
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    oddSum += currentDigit;
                }
                number = number / 10;
            }

            return oddSum;
        }
    }
}
