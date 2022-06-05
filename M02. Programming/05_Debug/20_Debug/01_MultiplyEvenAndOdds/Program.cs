using System;

namespace _01_MultiplyEvenAndOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleEvenAndOdds(n);
            Console.WriteLine(result);
        }

        static int GetSumEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                if(digit % 2 == 0)
                {
                    sum += digit;
                }

                number = number / 10;
            }

            return sum;
        }
        static int GetSumOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }

                number = number / 10;
            }

            return sum;
        }

        static int GetMultipleEvenAndOdds(int number)
        {
            int evenSum = GetSumEvenDigits(number);
            int oddSum = GetSumOddDigits(number);

            return evenSum * oddSum;
        }
    }
}
