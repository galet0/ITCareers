using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Pharmacy
{
    class Medicine
    {
        private string name;
        private double price;

        public Medicine(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public double Price
        {
            get { return price; }
            private set {
                if(value < 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                price = value; }
        }

        public override string ToString()
        {
            return $"Medicine: {Name} with price {Price:f2}";
        }
    }
}
