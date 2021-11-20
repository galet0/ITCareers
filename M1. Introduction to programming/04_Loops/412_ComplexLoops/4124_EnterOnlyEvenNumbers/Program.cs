using System;

namespace _4124_EnterOnlyEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error! Invalid number!" + ex.Message);
                }
            }
        }
    }
}
