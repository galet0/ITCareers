using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._3_DynamicQueue
{
    public class DynamicQueue<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        private Node<T> head;
        private Node<T> tail;
        private class Node<T>
        {
            public T item;
            public Node<T> next;

            public Node(T item)
            {
                this.item = item;
                this.next = null;
            }
            public Node(T item, Node<T> prevNode)
            {
                this.item = item;
                prevNode.next = this;
            }
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = null;

            if (this.Count == 0)
            {
                newNode = new Node<T>(item);
                this.head = newNode;
            }
            else
            {
                newNode = new Node<T>(item, this.tail);
            }

            this.tail = newNode;
            this.Count++;
        }

        public T Peek()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            return this.head.item;
        }

        public T Dequeue()
        {
            T item = this.Peek();
            this.head = this.head.next;

            this.Count--;
            return item;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int index = 0;

            Node<T> current = this.head;

            while (current != null)
            {
                array[index] = current.item;
                index++;
                current = current.next;
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            T[] arr = this.ToArray();

            foreach (var item in arr)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
