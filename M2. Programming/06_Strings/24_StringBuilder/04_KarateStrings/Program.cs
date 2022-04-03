using System;
using System.Text;

namespace _04_KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            //int startIndex = 0;
            int oldStrength = 0;
            int index = 0;
            string substr = input.ToString();

            while (substr.Contains(">"))
            {
                index = input.ToString().IndexOf('>', index + 1);
                int strength = int.Parse(input[index + 1].ToString()) + oldStrength;
                string next = input[index + 2].ToString();
                if(next == ">")
                {
                    input.Remove(index + 1, 1);
                    oldStrength = strength-1;
                }
                else
                {
                    input.Remove(index + 1, strength);
                }
                substr = input.ToString().Substring(index + 1);
                //startIndex++;
            }

            Console.WriteLine(input);
        }
    }
}
