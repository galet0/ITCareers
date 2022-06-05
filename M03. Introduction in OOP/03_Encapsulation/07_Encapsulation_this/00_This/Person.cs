using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_This
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return name; }
            private set 
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "Name can not be null or empty.");
                }
                name = value; 
            }
        }
    }
}
