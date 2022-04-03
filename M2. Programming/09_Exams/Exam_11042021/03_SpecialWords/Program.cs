using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SpecialWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());
            List<string> startsEnds = new List<string>();
            List<string> moreLettersa = new List<string>();
            List<string> notSpecial = new List<string>();

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                //dead
                if (word[0] == word[word.Length - 1])
                {
                    startsEnds.Add(word);
                }
                if(word.Where(l => l == 'a').Count() >= 2)
                {
                    moreLettersa.Add(word);
                }

                if(!startsEnds.Contains(word) && !moreLettersa.Contains(word))
                {
                    notSpecial.Add(word);
                }
                //if(!(word[0] == word[word.Length - 1]) 
                //    && !(word.Where(l => l == 'a').Count() >= 2))
                //{
                //    notSpecial.Add(word);
                //}
            }

            Console.WriteLine(string.Join(", ", startsEnds));
            Console.WriteLine(string.Join(", ", moreLettersa));
            Console.WriteLine(string.Join(", ", notSpecial));
        }
    }
}
