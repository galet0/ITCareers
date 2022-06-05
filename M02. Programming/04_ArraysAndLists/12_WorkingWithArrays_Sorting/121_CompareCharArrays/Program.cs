using System;
using System.Linq;

namespace _121_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            if (arr1.Length < arr2.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else if(arr2.Length < arr1.Length)
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
            else
            {
                int minLength = Math.Min(arr1.Length, arr2.Length);
                bool areEuals = false;

                for (int i = 0; i < minLength; i++)
                {
                    if(arr1[i] < arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        areEuals = false;
                        break;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                        areEuals = false;
                        break;
                    }
                    else
                    {
                        areEuals = true;
                        continue;
                    }
                }

                if (areEuals)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
        }
    }
}
