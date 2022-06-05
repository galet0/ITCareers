using System;
using System.Linq;

namespace _02_ConvertFromNthBaseTo10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = ConvertFromNthBaseTo10thBase(line[0], line[1]);

            Console.WriteLine(result);
        }
        static int ConvertFromNthBaseTo10thBase(int numBase, int number)
        {
            int sum = 0;
            int power = 0;
            while (number != 0)
            {
                sum += number % 10 * (int)Math.Pow(numBase, power);
                number = number / 10;
                power++;
            }

            return sum;
        }
    }
}
