using System;
using System.Collections.Generic;

namespace _04_OrderWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "wow", "softuni", "alpha" };
            Sort(words);

            Console.WriteLine(string.Join(", ", words));
        }

        static void Sort(List<string> words)
        {
            int n = words.Count;
            for (int i = 1; i < n; ++i)
            {
                string key = words[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && words[j].CompareTo(key) > 0)
                {
                    words[j + 1] = words[j];
                    j = j - 1;
                }
                words[j + 1] = key;
            }
        }
    }
}
