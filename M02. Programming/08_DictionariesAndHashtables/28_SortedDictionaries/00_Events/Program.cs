using System;
using System.Collections.Generic;

namespace _00_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new SortedDictionary<DateTime, string>();
            events[new DateTime(1998, 9, 4)] = "Google's birth date";
            events[new DateTime(2013, 11, 5)] = "SoftUni's birth date";
            events[new DateTime(1975, 4, 4)] = "Microsoft's birth date";
            events[new DateTime(2004, 2, 4)] = "Facebook's birth date";
            events[new DateTime(2013, 11, 5)] = "SoftUni was founded";
            foreach (var entry in events)
            {
                Console.WriteLine("{0:dd-MMM-yyyy}: {1}",
                   entry.Key, entry.Value);
            }
        }
    }
}
