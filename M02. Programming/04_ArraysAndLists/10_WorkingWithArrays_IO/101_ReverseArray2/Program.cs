using System;

namespace _101_ReverseArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            //a b c d e
            string[] array = Console.ReadLine().Split();
            //string[] copy = new string[array.Length];
            //Array.Reverse(array);

            //0 1 2 3 4
            //e d c b a
            //a  
            //5 - 0; 5 - 1
            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
