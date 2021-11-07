using System;

namespace _356_EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1 = Console.ReadLine();
            string w2 = Console.ReadLine();

            if (w1.ToLower().Equals(w2.ToLower()))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.WriteLine(w1);
            Console.WriteLine(w2);
        }
    }
}
