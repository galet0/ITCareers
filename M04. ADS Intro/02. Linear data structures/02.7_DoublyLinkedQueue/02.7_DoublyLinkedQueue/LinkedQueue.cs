using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._7_DoublyLinkedQueue
{
    class LinkedQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private class QueueNode<T>
        {
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }

            public QueueNode(T item)
            {
                this.Value = item;
            }
        }

        private QueueNode<T> head;
        private QueueNode<T> tail;
        public int Count { get; private set; }
        public void Enqueue(T element) 
        {
            QueueNode<T> newTail = new QueueNode<T>(element);
            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PrevNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }
        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            return this.head.Value;
        }
        public T Dequeue() 
        {
            T removed = this.Peek();

            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PrevNode = null;
            }
            else
            {
                this.tail = null;
            }
            //if (this.Count == 1)
            //{
            //    this.head = this.tail = null;
            //}
            //else
            //{
            //    this.head = this.head.Next;
            //    this.head.Prev = null;
            //}
            this.Count--;
            return removed;
        }
        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int index = 0;

            QueueNode<T> current = this.head;
            while (current != null)
            {
                array[index] = current.Value;
                index++;
                current = current.NextNode;
            }

            return array;
        }       

        public bool Contains(T element)
        {
            foreach (var item in this)
            {
                if(item.CompareTo(element) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            foreach (var item in this)
            {
                this.Dequeue();
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            QueueNode<T> current = this.head;
            while (current != null)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
