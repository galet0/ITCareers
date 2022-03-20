using System;
using System.Linq;

namespace _122_InsertElementInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length + 1];
            
            int index = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if(number >= array[i - index] || index == 1)
                {
                    newArray[i] = array[i - index];
                }
                else
                {
                    newArray[i] = number;
                    index = 1;
                }
            }

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
