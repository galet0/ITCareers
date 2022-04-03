using System;
using System.Collections.Generic;

namespace _03_FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());

            List<string> special = new List<string>();
            List<string> others = new List<string>();

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();

                if(word[0].ToString() == word[0].ToString().ToUpper()
                    && (word.Contains('i') || word.Contains('I'))
                    && word.Length > 7)
                {
                    special.Add(word);
                }
                else
                {
                    others.Add(word);
                }
            }

            Console.WriteLine($"Special words: {string.Join(", ", special)}");
            Console.WriteLine($"Other words: {string.Join(", ", others)}");
        }
    }
}
