using System;

namespace _493_AllLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
            
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
