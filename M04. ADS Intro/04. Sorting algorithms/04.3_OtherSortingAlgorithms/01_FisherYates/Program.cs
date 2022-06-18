using System;

namespace _01_FisherYates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};

            Shuffle<int>(array);

            Console.WriteLine(string.Join(", ", array));
        }

        public static void Shuffle<T>(T[] source)
        {
            Random rnd = new Random();

            for (int i = 0; i < source.Length; i++)
            {
                // Exchange array[i] with random element in array[i … n-1]

                int r = i + rnd.Next(0, source.Length - i);

                T temp = source[i];
                source[i] = source[r];
                source[r] = temp;
            }
        }
    }
}
