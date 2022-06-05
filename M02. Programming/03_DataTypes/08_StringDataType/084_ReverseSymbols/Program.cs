using System;

namespace _084_ReverseSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            string reversed = "" + ch3 + ch2 + ch1;
            Console.WriteLine(reversed);
            Console.WriteLine($"{ch3}{ch2}{ch1}");
        }
    }
}
