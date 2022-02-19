using System;

namespace _071_Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 3.256565656566565655656;
            float num2 = (float)num;
            int intNum = (int)num;
            Console.WriteLine(num2);
            Console.WriteLine(intNum);
        }
    }
}
