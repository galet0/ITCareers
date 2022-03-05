using System;
using System.Linq;

namespace _104_ConvertArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();           

            while (array.Length > 1)
            {
                int[] condensed = new int[array.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = array[i] + array[i + 1];//2 + 10; 10 + 3
                }

                array = condensed;
            }

            Console.WriteLine(array[0]);
        }
    }
}
