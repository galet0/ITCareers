using System;
using System.Collections;
using System.Collections.Generic;

namespace StretchingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();
            ArrayList<string> str = new ArrayList<string>();
            str.Add("hi");
            str.Add("bye");

            list.Add(5);
            list.Add(6);
            list.Add(7);
            try
            {
                Console.WriteLine(list.Count);
                Console.WriteLine(list[-1]);

                list[0] = 10;
                Console.WriteLine(list[0]);

                int removed = list.RemoveAt(1);
                Console.WriteLine(removed);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
