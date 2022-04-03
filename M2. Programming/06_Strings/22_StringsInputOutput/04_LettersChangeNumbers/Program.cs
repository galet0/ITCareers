using System;
using System.Text;

namespace _04_LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A12b s17G
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double result = 0;

            foreach (string word in words)
            {
                char first = word[0];
                char last = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsUpper(first))
                {
                    number = number / (first - 64);
                }
                else
                {
                    number = number * (first - 96);
                }

                if (char.IsUpper(last))
                {
                    number = number - (last - 64);
                }
                else
                {
                    number = number + (last - 96);
                }

                result += number;
            }

            Console.WriteLine($"{Math.Round(result,2)}");
        }
    }
}
