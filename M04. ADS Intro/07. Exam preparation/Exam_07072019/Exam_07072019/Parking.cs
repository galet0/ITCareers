using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_07072019
{
    public class Parking
    {
        private Car head;
        private Car tail;
        private int count;

        public int Count => this.count;

        public void AddCar(string carNumber)
        {
            Car car = null;

            if(this.Count == 0)
            {
                car = new Car(carNumber);
                this.head = this.tail = car;
            }
            else
            {
                car = new Car(carNumber, this.tail);
                this.tail = car;
            }

            this.count++;
        }

        public void AddFancyCar(string carNumber)
        {
            if(this.Count == 0)
            {
                this.AddCar(carNumber);
            }
            else
            {
                Car car = new Car(carNumber);
                car.Next = this.head;
                this.head = car;
                this.count++;
            }
        }

        public Car CheckCarIsPresent(string carNumber)
        {
            Car currentCar = this.head;

            while (currentCar != null)
            {
                if (currentCar.CarNumber == carNumber)
                {
                    return currentCar;
                }

                currentCar = currentCar.Next;
            }

            return null;
        }

        public bool ReleaseCar(string carNumber)
        {
            int index = this.IndexOfCarNumber(carNumber);

            if(index != -1)
            {
                return this.ReleaseCar(index);
            }

            return false;
        }

        private int IndexOfCarNumber(string carNumber)
        {
            int index = 0;

            Car currentCar = this.head;

            while(currentCar != null)
            {
                if(currentCar.CarNumber == carNumber)
                {
                    return index;
                }

                index++;
                currentCar = currentCar.Next;
            }

            return -1;
        }

        public bool ReleaseCar(int index)
        {
            Car previousCar = null;
            Car currentCar = this.head;
            int currentIndex = 0;

            if (!CheckIndex(index))//false
            {
                return false;
            }

            while (currentCar != null)
            {
                if(currentIndex == index)
                {
                    if (previousCar == null)
                    {
                        this.head = this.head.Next;
                        if(this.head == null)
                        {
                            this.tail = null;
                        }
                    }
                    else
                    {
                        if (index == this.Count - 1)
                        {
                            previousCar.Next = null;
                            this.tail = previousCar;
                        }
                        else
                        {
                            previousCar.Next = currentCar.Next;
                        }

                    }
                    this.count--;
                    return true;
                }
                currentIndex++;
                previousCar = currentCar;
                currentCar = currentCar.Next;
            }

            return false;
        }

        private bool CheckIndex(int index)
        {
            if(index < 0 || index >= this.Count)
            {
                return false;
            }

            return true;
        }

        public StringBuilder ParkingInformation()
        {
            StringBuilder sb = new StringBuilder();

            if(this.Count == 0)
            {
                return sb.AppendLine("<Parking is empty!>");
            }

            Car currentCar = this.head;
            while (currentCar != null)
            {
                sb.AppendLine(currentCar.ToString());
                currentCar = currentCar.Next;
            }

            return sb;
        }

    }
}
