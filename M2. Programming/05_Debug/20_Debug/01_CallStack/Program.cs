using System;

namespace _01_CallStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        static void MethodA()
        {
            Console.WriteLine("Method A");
            MethodB();
        }

        static void MethodB()
        {
            Console.WriteLine("Method B");
        }
    }
}
