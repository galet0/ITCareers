using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Train_v2
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            this.Number = number;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }

        public int Number { get => this.number; private set => this.number = value; }
        public string Name { get => this.name; private set => this.name = value; }
        public string Type { get => this.type; private set => this.type = value; }
        public int Cars { get => this.cars; private set => this.cars = value; }

        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Type} {this.Cars}";
        }
    }
}
