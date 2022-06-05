using System;

namespace _02_AverageByRows
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int number = int.Parse(Console.ReadLine());
                    matrix[row, col] = number;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                double avg = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    avg += matrix[row, col];
                    Console.Write("{0, 10}", matrix[row, col]);
                }
                Console.WriteLine("{0, 10}", avg/cols);
            }
        }
    }
}
