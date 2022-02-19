using System;

namespace _082_StringandChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I love programming love";
            Console.WriteLine(str.Length);
            Console.WriteLine(str[2]);
            Console.WriteLine(str.IndexOf("programming"));
            Console.WriteLine(str.LastIndexOf("love"));
            Console.WriteLine(str.Replace("programming", "music"));

            string input = Console.ReadLine();
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            string input2 = Console.ReadLine();

            Console.WriteLine(input);
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(input2);
            

        }
    }
}
