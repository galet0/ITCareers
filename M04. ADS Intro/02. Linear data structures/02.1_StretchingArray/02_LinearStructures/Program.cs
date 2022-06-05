using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_LinearStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add("five");

            foreach (var item in arrayList)
            {
                if(item.GetType().Name == "Int32")
                {
                    Console.WriteLine((int)item + 1);
                }
                else
                {
                    Console.WriteLine((int)item + 1);
                }
            }

            List<int> list = new List<int>();
            list.Add(5);
            list.Add(6);

            LinkedList
        }
    }
}
