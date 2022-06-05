using System;

namespace _081_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";//0x00000183DB85B628
            string str2 = str;   //0x00000183DB85B628

            Console.WriteLine(str);
            Console.WriteLine(str2);
            str = "world";
            
            Console.WriteLine(str);
            Console.WriteLine(str2);

            int num = 5;
            double num2 = 2.5;
            bool b = true;

            object obj = str;
            Console.WriteLine(obj);
            obj = num;
            Console.WriteLine(num);
            obj = num2;
            obj = b;

            string firstName = "Pesho";
            string lastName = "Peshev";

            string fullName = firstName + " " + lastName; //$"{firstName} {lastName}";
            Console.WriteLine("Hello, \"{0}\" {1}", fullName, firstName);

        }
    }
}
