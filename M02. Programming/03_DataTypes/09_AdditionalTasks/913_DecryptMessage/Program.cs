using System;

namespace _913_DecryptMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = null;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += (char)(symbol + key);
            }

            Console.WriteLine(message);
        }
    }
}
