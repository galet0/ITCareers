using System;
using System.Text;

namespace _00_ChangeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World ");
            sb[5] = ',';
            Console.WriteLine(sb);
            Console.WriteLine("Capacity: " + sb.Capacity);
            Console.WriteLine("Lenght: " + sb.Length);

            Console.WriteLine(ReverseString("asdasd"));

            StringBuilder builder = new StringBuilder();
            builder.Append("Hello Maria, how are you?");
            Console.WriteLine(builder);
            builder[6] = 'D';
            Console.WriteLine(builder);
            builder.Remove(5, 6);
            Console.WriteLine(builder);
            builder.Insert(5, " Peter Peter");
            Console.WriteLine(builder);
            builder.Replace("Peter", "George");
            Console.WriteLine(builder);
        }

        public static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

    }
}
