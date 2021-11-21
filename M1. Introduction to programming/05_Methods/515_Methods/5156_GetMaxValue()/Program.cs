using System;

namespace _5156_GetMaxValue__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(6, 3));
            Console.WriteLine(GetMax('a', 'a'));
            Console.WriteLine(GetMax("aa", "bb"));
            Console.WriteLine(GetMax("cc", "bb"));
            Console.WriteLine(GetMax("aaa", "bb"));
            Console.WriteLine(GetMax("aaa", "aa"));
        }

        static string GetMax(string str1, string str2)
        {
            if(str1.CompareTo(str2) < 0)
            {
                return str2;
            }
            else
            {
                return str1;
            }
        }
        static char GetMax(char ch1, char ch2)
        {
            char result = (char)Math.Max(ch1, ch2);
            return result;
        }
        static int GetMax(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
