using System;
using System.Linq;

namespace _03_MinimumByCols
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            /*
             1 2 3 5
             8 6 9 4
             5 8 4 3
             */
            int[] mins = new int[cols];
            for (int col = 0; col < cols; col++)
            {
                int min = matrix[0, col];
                for (int row = 1; row < rows; row++)
                {
                    //[0,0], [1, 0], [2,0]
                    if(matrix[row, col] < min)
                    {
                        min = matrix[row, col];
                    }
                }

                mins[col] = min;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }
            Console.WriteLine(string.Join(" ", mins));

        }
    }
}
