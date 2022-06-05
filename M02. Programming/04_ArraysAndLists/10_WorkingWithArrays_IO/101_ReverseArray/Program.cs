using System;

namespace _101_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            //0 -> 10; 1 -> 20; 2 -> 30   
            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //length = 3
            //0 1 2
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
