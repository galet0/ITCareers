using System;

namespace _4115_Sequence2Kplus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            while (num <= n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }

        }
    }
}
