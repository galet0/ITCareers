using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Train
{
    public class Deque<T>
    {
        private const int defaultCapacity = 16;
        private int capacity;
        private List<T> trains;
        private Stack<T> history;
        public Deque() : this(defaultCapacity) 
        {

        }
        public Deque(int capacity)
        {
            this.capacity = capacity;
            this.trains = new List<T>(capacity);
            this.history = new Stack<T>();
        }
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
            this.trains.AddRange(collection);
        }
        public int Capacity => this.capacity;
        public int Count => this.trains.Count;
        public void AddFront(T item)
        {
            this.trains.Insert(0, item);
        }
        public void AddBack(T item)
        {
            this.trains.Add(item);
        }
        public T RemoveFront()
        {
            //връща и премахва елемента отпред
            T removed = this.trains[0];
            this.trains.RemoveAt(0);
            this.history.Push(removed);

            return removed;
        }
        public T RemoveBack()
        {
            //връща и премахва елемента отзад
            T removed = this.trains[this.trains.Count - 1];
            this.trains.RemoveAt(this.trains.Count - 1);
            this.history.Push(removed);

            return removed;
        }
        public T GetFront()
        {
            //връща, без да премахва, елемента отпред
            return this.trains[0];
        }
        public T GetBack()
        {
            //връща, без да премахва, елемента отзад
            return this.trains[this.trains.Count - 1];
        }

        public void PrintHistory()
        {
            foreach (var train in this.history)
            {
                Console.WriteLine(train);
            }
        }
    }
}
