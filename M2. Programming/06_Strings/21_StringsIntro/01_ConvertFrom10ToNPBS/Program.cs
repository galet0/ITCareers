using System;
using System.Linq;

namespace _01_ConvertFrom10ToNPBS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = ConvertNumberInNthSystem(line[0], line[1]);

            Console.WriteLine(result);
        }

        static string ConvertNumberInNthSystem(int numBase, int number)
        {
            string result = "";

            while(number != 0)
            {
                result += number % numBase;
                number /= numBase;
            }

            result = string.Join("", result.Reverse());

            return result;
        }
    }
}
