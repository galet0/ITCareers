using System;

namespace _01_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "gmvasko@gmail.org";
            int firstIndex = email.IndexOf("@"); // 5
            int secondIndex = email.IndexOf("a", 2); // 8
            int notFound = email.IndexOf("/"); // -1
            int gmailIndex = email.IndexOf("gma");
            Console.WriteLine(gmailIndex);
        }
    }
}
