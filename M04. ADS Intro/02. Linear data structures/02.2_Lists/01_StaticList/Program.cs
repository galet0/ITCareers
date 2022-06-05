using System;

namespace _01_StaticList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList<string> list = new CustomArrayList<string>();

            list.Add("first");
            list.Add("second");
            list.Add("third");
            list.Insert(1, "asd");
            Console.WriteLine("IndexOf = " + list.IndexOf("third"));
            Console.WriteLine("Contains = " + list.Contains("second"));
            Console.WriteLine("Contains = " + list.Contains("fifth"));
            Console.WriteLine(list[2]);
            Console.WriteLine(list.RemoveAt(0));
            Console.WriteLine(list.Remove("asd"));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
