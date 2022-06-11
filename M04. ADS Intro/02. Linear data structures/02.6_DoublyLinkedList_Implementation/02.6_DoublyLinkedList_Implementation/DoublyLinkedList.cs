using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._6_DoublyLinkedList_Implementation
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Prev { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }

        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            Node<T> newHead = new Node<T>(item);
            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.Next = this.head;
                this.head.Prev = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T item)
        {
            Node<T> newTail = new Node<T>(item);
            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.Prev = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            T removed = default;

            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            removed = this.head.Value;
            this.head = this.head.Next;
            if(this.head != null)
            {
                this.head.Prev = null;
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
        public T RemoveLast()
        {
            T removed = default;

            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            removed = this.tail.Value;
            this.tail = this.tail.Prev;
            if (this.tail != null)
            {
                this.tail.Next = null;
            }
            else
            {
                this.head = null;
            }
            //if (this.Count == 1)
            //{
            //    this.tail = this.head = null;
            //}
            //else
            //{
            //    this.tail = this.tail.Prev;
            //    this.tail.Next = null;
            //}
            this.Count--;
            return removed;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int index = 0;

            Node<T> current = this.head;
            while (current != null)
            {
                array[index] = current.Value;
                index++;
                current = current.Next;
            }

            return array;
        }

        public void ForEach(Action<T> action)
        {
            Node<T> current = this.head;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
