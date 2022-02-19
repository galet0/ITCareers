using System;

namespace _074_CharDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'щ';
            Console.WriteLine((int)a);
            Console.WriteLine(Convert.ToString((int)a, 2));
        }
    }
}
