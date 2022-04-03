using System;

namespace _198_GetMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(10, 15));
            Console.WriteLine(GetMax("asd", "gfg"));
            Console.WriteLine(GetMax('a', 'b'));
        }

        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        static string GetMax(string str1, string str2)
        {
            if(str1.CompareTo(str2) > 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

        static char GetMax(char ch1,char ch2)
        {
            if(ch1 > ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }
    }
}
