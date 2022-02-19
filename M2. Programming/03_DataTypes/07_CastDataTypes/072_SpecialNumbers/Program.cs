using System;

namespace _072_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = SumDigits(i);//1
                bool isSpecial = currentNumber == 5 || currentNumber == 7 || currentNumber == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }

        public static int SumDigits(int num)
        {
            //12
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
