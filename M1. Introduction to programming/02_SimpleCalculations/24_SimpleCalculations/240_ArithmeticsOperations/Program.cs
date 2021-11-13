using System;

namespace _240_ArithmeticsOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 21;

            var sum = a + b;
            var diff = a - b;
            var product = a * b;
            double div = a / b;
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(product);
            Console.WriteLine(div);
            Console.WriteLine(25 / 0.0);
            Console.WriteLine(0.0 / 0.0);
            //int c = 0;
            //Console.WriteLine(5 / c);

            string firstName = "Maria";
            string lastName = "Ivanova";
            int age = 15;
            string result = firstName +" "+ lastName +" "+ age;
            string result2 = $"{firstName} {lastName} at {age}.";
            Console.WriteLine(result);
            Console.WriteLine(result2);

            var up = Math.Ceiling(23.45);
            Console.WriteLine(up);

            var down = Math.Floor(45.67);
            Console.WriteLine(down);

            var one = Math.Round(112.345, 1);   // 112.3
            var two = Math.Round(123.456, 2);   // 123.46
            var three = Math.Round(566.7899, 3);

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
        }
    }
}
