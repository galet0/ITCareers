using System;
using System.Linq;

namespace _04_LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = array[0];
            int currentCount = 1;
            int maxCount = 0;
            int maxValue = 0;

            for (int i = 1; i < array.Length; i++)
            {
                //12 2 7 4 3 3 8
                if (number == array[i])
                {
                    currentCount++;
                    if(currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxValue = number;
                    }
                }
                else
                {
                    currentCount = 1;
                    number = array[i];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxValue} ");
            }
        }
    }
}
