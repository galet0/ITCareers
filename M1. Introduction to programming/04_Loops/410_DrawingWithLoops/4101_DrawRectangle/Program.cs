using System;

namespace _4101_DrawRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10 ; i++)
            //{
            //    Console.WriteLine(new string('*', 10));
            //}

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
