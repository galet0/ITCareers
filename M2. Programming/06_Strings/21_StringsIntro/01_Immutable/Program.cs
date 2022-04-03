using System;

namespace _01_Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mirko";
            int age = 22;
            string result = name + age;
            Console.WriteLine(result);
            char[] chArray = name.ToCharArray();
            string str = new string(chArray);
            Console.WriteLine(name[2]);

            string str1 = "Abc";
            string str2 = "abc";
            Console.WriteLine(string.Concat(str1, str2));
            Console.WriteLine(str1 + " " + str);
            Console.WriteLine($"{str} {str1} {str2}");
            Console.WriteLine(string.Compare(str1, str2, false));

            string res = "";
            for (int i = 0; i < 10000; i++)
            {
                res += "abdhsabdjshadgsjdgsjdsgdhsjds";
            }
            Console.WriteLine(res);
        }
    }
}
