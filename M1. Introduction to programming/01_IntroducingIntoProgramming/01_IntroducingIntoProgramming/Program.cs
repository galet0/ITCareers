using System;

namespace _01_IntroducingIntoProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 200; i <= 4000; i += 200)
                Console.Beep(i, 100);

        }
    }
}
