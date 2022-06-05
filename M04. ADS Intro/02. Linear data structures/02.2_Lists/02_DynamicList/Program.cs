using System;

namespace _02_DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("1");
            list.Add("2");
            list.Add("3");
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("IndexOf = " + list.IndexOf("3"));
            Console.WriteLine("RemoveAt = " + list.RemoveAt(2));
            Console.WriteLine("Remove = " + list.Remove("3"));
            Console.WriteLine("Contains = " + list.Contains("2"));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
