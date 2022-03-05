using System;

namespace _103_IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            int index = 0;
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                letters[index] = ch;
                index++;
            }

            //abcz
            string word = Console.ReadLine().ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                for (int ch = 0; ch < letters.Length; ch++)
                {
                    if(word[i] == letters[ch])
                    {
                        Console.WriteLine($"{word[i]} -> {ch}");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
