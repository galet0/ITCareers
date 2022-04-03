using System;

namespace _192_EmptyReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            Header();
            Body();
            Footer();
        }
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }

        static void Body()
        {
            Console.WriteLine("Charged to____________________");

            Console.WriteLine("Received by___________________");
        }

        static void Footer()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
