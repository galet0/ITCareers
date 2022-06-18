using System;
using System.Collections.Generic;

namespace _02_CorrespondingSquareBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5";
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(')
                {
                    indexes.Push(i);
                }
                if(expression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    string subString = expression.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(subString);
                }
            }
        }
    }
}
