using System;

namespace _5151_ReturnTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            AddOne(2);
            int num = PlusOne(5);
            Console.WriteLine(num);

            string fullName = ReadFullName();
            Console.WriteLine(fullName);
        }

        static void AddOne(int num)
        {
            num = num + 1;
            Console.WriteLine(num);
        }

        static int PlusOne(int num)
        {
            return num + 1;
        }

        static string ReadFullName()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            return GetFullName(firstName,lastName);
        }

        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
