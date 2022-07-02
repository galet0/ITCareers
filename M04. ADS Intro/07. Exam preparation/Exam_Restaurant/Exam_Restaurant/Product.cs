using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Restaurant
{
    class Product
    {
        private string name;
        private Product next;

        public Product(string name)
        {
            this.Name = name;
        }

        public Product(string name, Product tail)
        {
            this.Name = name;
            tail.Next = this;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Product Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public override string ToString()
        {
            return $"Product {this.Name}";
        }

    }
}
