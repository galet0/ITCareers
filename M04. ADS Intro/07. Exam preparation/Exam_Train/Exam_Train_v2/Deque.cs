using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Train_v2
{
    public class Deque<T> //: IList<T>
    {
        private const int DefaultCapacity = 16;

        private Stack<T> pTrains;
        private Stack<T> fTrains;
        private Stack<T> history;

        public Deque(int capacity)
        {
            //създава дека с точно зададен капацитет
            this.pTrains = new Stack<T>(capacity);
            this.fTrains = new Stack<T>(capacity);
            this.history = new Stack<T>(capacity);
            this.Capacity = capacity;
        }

        public Deque() : this(DefaultCapacity)
        {
            //празен конструктор, задава капацитета на дека на стойността по подразбиране (16)

        }

        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на 
            //посочената колекция и прехвърля елементите от колекцията в дека
            foreach (var item in collection)
            {
                if (item is Train)
                {
                    Train train = (Train)Convert.ChangeType(item, typeof(Train));
                    if (train.Type == "P")
                    {
                        pTrains.Push(item);
                    }
                    else if (train.Type == "F")
                    {
                        fTrains.Push(item);
                    }
                }
            }
        }
        public int Capacity; //показва капацитета
        public int Count; //показва броят елементи

        public void AddFront(T item)
        {
            //добавя елемент отпред
            this.pTrains.Push(item);
            this.Count++;
        }

        public void AddBack(T item)
        {
            //добавя елемент отзад
            this.fTrains.Push(item);
            this.Count++;
        }

        public T RemoveFront()
        {
            //връща и премахва елемента отпред
            if (this.pTrains.Count > 0)
            {
                this.history.Push(this.pTrains.Peek());
                this.Count--;
                return this.pTrains.Pop();
            }

            return default(T);
        }

        public void PrintHistory()
        {
            foreach (var train in this.history)
            {
                Console.WriteLine(train);
            }
        }

        public T RemoveBack()
        {
            //връща и премахва елемента отзад
            if (this.fTrains.Count > 0)
            {
                this.history.Push(this.fTrains.Peek());
                this.Count--;
                return this.fTrains.Pop();
            }

            return default(T);
        }

        public T GetFront()
        {
            //връща, без да премахва, елемента отпред
            if (this.pTrains.Count > 0)
            {
                return this.pTrains.Peek();
            }

            return default(T);
        }

        public T GetBack()
        {
            //връща, без да премахва, елемента отзад
            if (this.fTrains.Count > 0)
            {
                return this.fTrains.Peek();
            }

            return default(T);
        }

        public T[] GetHistory()
        {
            return this.history.ToArray();
        }
    }
}
