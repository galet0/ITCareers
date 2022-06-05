using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OldestFamilyMember
{
    class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }

        public void AddMemeber(Person person)
        {
            members.Add(person);
        }

        public Person GetOldestMember()
        {
            return members.OrderByDescending(p => p.Age)
                .FirstOrDefault();
        }

        public void PrintOldestOver(int age)
        {
            members.Where(m => m.Age > age)
                .OrderBy(m => m.Name)
                .ToList()
                .ForEach(m => Console.WriteLine(m));            
        }
    }
}
