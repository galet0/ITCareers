using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PersonAndFamily
{
    public class Family
    {
        private List<Person> members;
        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public string GetOlderThan(int age)
        {
            members = members.OrderBy(m => m.Age)
                .Where(m => m.Age > age)
                .ToList();

            return this.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var sorted = members.OrderBy(m => m.Name);
            foreach (var member in sorted)
            {
                sb.AppendLine(member.ToString());
            }

            return sb.ToString();
        }
    }
}
