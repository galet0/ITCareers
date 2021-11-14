using System;

namespace _496_FindMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if(current < min)
                {
                    min = current;
                }
            }

            Console.WriteLine(min);
        }
    }
}
