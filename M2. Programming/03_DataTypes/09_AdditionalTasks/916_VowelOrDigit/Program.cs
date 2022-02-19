using System;

namespace _916_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            string vowels = "AaEeIiOoUuYy";

            if (vowels.Contains(ch))
            {
                Console.WriteLine("vowel");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
