using System;

namespace _99_WordCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = null;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
