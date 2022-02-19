using System;

namespace _061_FloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0f, b = 0.33f, sum = 1.33;
            Console.WriteLine("a+b={0} sum={1} equal={2}",
              a + b, sum, (a + b == sum));

            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(num2);
            decimal num3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(num3);


            Console.WriteLine();
            Console.WriteLine(10000000000000000.0m + 0.3m);

           

            decimal one = 0m;
            for (int i = 0; i < 10000; i++)
                one += 0.0001m;
            Console.WriteLine(one);

            double num = 3.453;
            Console.WriteLine(Math.Round(num,2));
            Console.WriteLine(Math.Ceiling(num));
            Console.WriteLine(Math.Floor(num));

            double d = 10000000000000000000000000000000000.0;
            Console.WriteLine(d); // 1E+34
            double d2 = 20e-3;
            Console.WriteLine(d2); // 0.02
            double d3 = double.MaxValue;
            Console.WriteLine(d3); // 1.79769313486232E+308

            Console.WriteLine(10/4.0);
            double zero = 0.0;
            Console.WriteLine(10/zero);
            Console.WriteLine(0/0.0);


        }
    }
}
