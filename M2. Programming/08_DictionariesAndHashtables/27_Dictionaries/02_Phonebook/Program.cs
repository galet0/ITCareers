using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        if (!phonebook.ContainsKey(input[1]))
                        {
                            phonebook.Add(input[1], null);
                        }
                        phonebook[input[1]] = input[2];
                        break;
                    case "S":
                        if (phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                        break;
                    case "D":
                        if (phonebook.ContainsKey(input[1]))
                        {
                            phonebook.Remove(input[1]);
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                        break;
                    case "ListAll":

                        phonebook = phonebook.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);

                        foreach (var item in phonebook)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }
            
        }
    }
}
