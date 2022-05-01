using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RawData
{
    class Tire
    {
        private double pressure;
        private int age;

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }        
        public double Pressure
        {
            get { return pressure; }
            private set { pressure = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
    }
}
