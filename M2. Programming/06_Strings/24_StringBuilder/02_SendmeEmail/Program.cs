using System;
using System.Text;

namespace _02_SendmeEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int index = input.IndexOf('@');
            int sumBefore = 0;
            int sumAfter = 0;

            for (int i = 0; i < index; i++)
            {
                sumBefore += input[i];
            }

            for (int i = index + 1; i < input.Length; i++)
            {
                sumAfter += input[i];
            }

            if(sumAfter - sumBefore >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
