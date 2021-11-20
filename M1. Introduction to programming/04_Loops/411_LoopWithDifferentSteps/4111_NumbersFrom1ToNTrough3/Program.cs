using System;

namespace _4111_NumbersFrom1ToNTrough3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=3) //i = i + 3
            {
                Console.WriteLine(i);
            }
        }
    }
}
