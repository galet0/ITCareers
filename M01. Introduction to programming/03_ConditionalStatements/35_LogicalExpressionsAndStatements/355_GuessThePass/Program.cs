using System;

namespace _355_GuessThePass
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretPass = "s3cr3t!P@ssw0rd";
            string password = Console.ReadLine();
            if (password.Equals(secretPass))
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
