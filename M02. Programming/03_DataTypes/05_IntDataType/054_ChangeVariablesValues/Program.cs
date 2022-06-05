using System;

namespace _054_ChangeVariablesValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;//Hello
            int b = 10;//World

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int temp = a; //5
            a = b; //10
            b = temp;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
