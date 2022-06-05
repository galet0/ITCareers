using System;
using System.Collections.Generic;

namespace _01_OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            //java - 1
            //c# - 1
            //php - 2
            //c - 1
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            
            for (int i = 0; i < words.Length; i++)
            {
                if (!occurences.ContainsKey(words[i].ToLower()))
                {
                    occurences.Add(words[i].ToLower(), 0);
                }
                occurences[words[i].ToLower()]++;
            }
            string result = "";
            foreach (var word in occurences)
            {
                if(word.Value % 2 != 0)
                {
                    result += $"{word.Key}, ";
                }
            }

            Console.WriteLine(result.Remove(result.LastIndexOf(", ")));
        }
    }
}
