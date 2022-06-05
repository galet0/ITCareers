using System;
using System.Text;

namespace _5142_PrintReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }

        static void PrintBody()
        {
            Console.WriteLine($"Charged to {new string('_', 19)}");
            Console.WriteLine($"Received by {new string('_', 18)}");
        }

        static void PrintFooter()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"\u00A9 SoftUni");
        }
    }
}
