using System;

namespace _495_FindMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.Parse(Console.ReadLine());//-10

            for (int i = 0; i < n - 1; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > max)
                {
                    max = current;
                }
            }

            Console.WriteLine(max);

            //Console.Write("n = ");
            //var n = int.Parse(Console.ReadLine());
            //long max = long.MinValue;
            //for (var i = 1; i <= n; i++)
            //{
            //    var num = long.Parse(Console.ReadLine());
            //    if (num > max)
            //        max = num;
            //}
            //Console.WriteLine("max = " + max);

        }
    }
}
