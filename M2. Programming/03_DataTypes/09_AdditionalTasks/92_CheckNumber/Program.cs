using System;

namespace _92_CheckNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            double b;
            string myStr = Console.ReadLine();

            if (long.TryParse(myStr, out a))//true
            {
                Console.WriteLine("integer");
            }
            else if(double.TryParse(myStr, out b))
            {
                Console.WriteLine("floating-point");
            }
        }

        static void Variant1()
        {
            string number = Console.ReadLine();//"2.31"

            if (number.Contains("."))
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}
