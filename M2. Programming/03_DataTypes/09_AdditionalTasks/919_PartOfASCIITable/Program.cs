using System;

namespace _919_PartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = start; i <= end; i++)
            {
                result += (char)i + " ";
            }

            Console.WriteLine(result);
        }
    }
}
