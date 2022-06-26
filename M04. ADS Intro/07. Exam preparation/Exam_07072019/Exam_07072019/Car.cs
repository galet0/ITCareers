using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_07072019
{
    public class Car
    {
        private string carNumber;
        private Car next;

        public Car(string carNumber)
        {
            this.carNumber = carNumber;
        }

        public Car(string carNumber, Car prev) : this(carNumber)
        {
            prev.next = this;
        }

        public string CarNumber
        {
            get { return carNumber; }
        }
        public Car Next
        {
            get { return next; }
            set { this.next = value; }
        }

        public override string ToString()
        {
            return $"Car {this.CarNumber}";
        }
    }
}
