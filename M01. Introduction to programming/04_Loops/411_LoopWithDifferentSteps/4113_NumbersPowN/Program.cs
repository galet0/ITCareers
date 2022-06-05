using System;

namespace _4113_NumbersPowN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int pow = int.Parse(Console.ReadLine());

            for (int i = 0; i <= pow; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}
