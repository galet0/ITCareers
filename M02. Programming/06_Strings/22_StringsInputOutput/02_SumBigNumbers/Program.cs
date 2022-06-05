using System;
using System.Text;

namespace _02_SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            string second = Console.ReadLine().TrimStart('0');

            int length = Math.Max(first.Length, second.Length);
            first = first.PadLeft(length, '0');
            second = second.PadLeft(length, '0');
            StringBuilder result = new StringBuilder();
            int reminder = 0;
            //231
            //023
            for (int i = length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(first[i].ToString());
                int num2 = int.Parse(second[i].ToString());
                int sum = num1 + num2 + reminder;//4 max->18
                int lastDigit = sum % 10;
                result.Append(lastDigit);
                reminder = sum / 10;
            }

            if (reminder > 0)
            {
                result.Append(reminder);
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
