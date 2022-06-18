using System;

namespace _03_RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintFigure(n);
        }
        static void PrintFigure(int n)
        {
            if (n == 0) // Bottom of the recursion
                return;

            // предварително действие: отпечатва n звездички
            Console.WriteLine(new string('*', n));

            // рекурсивно извикване: отпечатва фигура с размер n-1
            PrintFigure(n - 1);

            // последващо действие: отпечатва n хештаг-а # (диез)
            Console.WriteLine(new string('#', n));
        }

    }
}
