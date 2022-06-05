using System;

namespace _01_MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (text.Contains(pattern) 
                && (pattern.Length != 0 
                || text.Length > pattern.Length))
            {
                int firstIndex = text.IndexOf(pattern);
                text = text.Remove(firstIndex, pattern.Length);

                int lastIndex = text.LastIndexOf(pattern);
                text = text.Remove(lastIndex, pattern.Length);
                Console.WriteLine("Shaked it.");
                int middleIndex = pattern.Length / 2;
                pattern = pattern.Remove(middleIndex, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
