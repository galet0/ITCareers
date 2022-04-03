using System;

namespace _00_JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[3];

            int[][] jaggedArray2 = {
                                new int[] { 2, 8, 4, 6},
                                new int[] { 3, 6},
                                new int[] { 10, 20, 40}
                            };

            Console.WriteLine(jaggedArray2[1][0]);

            int[][,] jaggedOfTwo = new int[2][,];
            jaggedOfTwo[0] = new int[,] { { 5, 3 }, { 2, 9 } };
            jaggedOfTwo[1] = new int[,] { { 3, 5, 2 }, { 8, 2, 9 } };
            Console.WriteLine(jaggedOfTwo[0][1, 0]);
        }
    }
}
