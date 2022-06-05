using System;

namespace _5155_Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(10);
            Print("Hello!");
            Print("Hello!", 10);
        }
        static void Print(string text)
        {
            Console.WriteLine(text);
        }
       
        static void Print(int number)
        {
            Console.WriteLine(number);
        }
        static void Print(string text, int number)
        {
            Console.WriteLine(text + ' ' + number);
        }

    }
}
