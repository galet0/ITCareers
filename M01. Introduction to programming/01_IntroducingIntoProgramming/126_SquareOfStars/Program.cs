using System;

namespace _126_SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //прочита от конзолата цяло положително число 
            int n = int.Parse(Console.ReadLine());

            //отпечатва на конзолата квадрат от N звездички
            Console.WriteLine(new string('*', n));
            //middle
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string(' ', n-2));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
