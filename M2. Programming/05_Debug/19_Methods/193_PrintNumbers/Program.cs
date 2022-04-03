using System;

namespace _193_PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("text");
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

       
        

        static string ReadFullName()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }
        
       
       
        static void PrintStudent(string name, int age, double grade)
        {
            Console.Write("Student: {0}; Age: {1}, Grade: {2}",
                name, age, grade);
        }

        static void PrintNumbers(int start = 0, int end = 100)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
