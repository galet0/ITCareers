using System;

namespace _5143_PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudent("Ivan", 16, 5);

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            PrintNumbers(num1, num2);
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }

        static void PrintStudent(string name, int age, double grade)
        {
            Console.WriteLine($"Student: {name}; Age: {age}; Grade: {grade}.");
        }
    }
}
