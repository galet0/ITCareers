using System;

namespace _00_DeclaringArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];//table rows = 3; cols = 4
            int[,] table =
            {
                { 2, 8, 3, 5},
                { 7, 9, 0, 3},
                { 8, 5, 7, 4}
            };
            //table[row, col]
            //Console.WriteLine(table[1, 1]);

            //print table
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write($"{table[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
