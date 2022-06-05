using System;

namespace _02_ConvertLevaInEuro
{
    class Program
    {
        static void Main(string[] args)
        {
            var leva = int.Parse(Console.ReadLine());
            double euro = leva / 1.95583;
            Console.WriteLine($"{euro:f2}");
        }
    }
}
