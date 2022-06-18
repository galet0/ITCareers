using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_OrderWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            for (int i = 0; i < words.Count; i++)
            {
                string minimum = words[i];
                int minimumPos = i;

                for (int j = i; j < words.Count; j++)
                {
                    if(minimum.CompareTo(words[j]) > 0)
                    {
                        minimum = words[j];
                        minimumPos = j;
                    }
                }

                words[minimumPos] = words[i];
                words[i] = minimum;
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
