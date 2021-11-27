using System;

namespace _05_Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = new string('-', n * 3) + "**" + new string('-', n * 2 - 2)+"\r\n";

            for (int row = 1; row < n; row++)
            {
                line += new string('-', n * 3) + "*" + new string('-', row)+ '*' + new string('-', n * 2 - 2 - row)+"\r\n";
            }

            for (int row = 0; row < n/2; row++)
            {
                line += new string('*', n * 3)+ '*' + new string('-', n - 1) + '*' + new string('-', n - 1) + "\r\n";
            }
            for (int row = 0; row < n / 2; row++)
            {
                if(row == n / 2 - 1)
                {
                    line += new string('-', n * 3 - row) + '*' + new string('*', n - 1 + row * 2) + '*' + new string('-', n - 1 - row) + "\r\n";
                }
                else
                {
                    line += new string('-', n * 3 - row) + '*' + new string('-', n - 1 + row * 2) + '*' + new string('-', n - 1 - row) + "\r\n";
                }
                
            }
            

            Console.WriteLine(line);
        }
    }
}
