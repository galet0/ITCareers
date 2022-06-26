using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Train
{
    public class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            Number = number;
            Name = name;
            Type = type;
            Cars = cars;
        }

        public int Number
        {
            get { return number; }
            private set { number = value; }
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Type
        {
            get { return type; }
            private set { type = value; }
        }
        public int Cars
        {
            get { return cars; }
            private set { cars = value; }
        }

        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Type} {this.Cars}";
        }
    }
}
