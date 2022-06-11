using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._8_Stack_DynamicImplementation
{
    public class LinkedStack<T> : IEnumerable<T> where T : IComparable<T>
    {
        private class Node<T>
        {
            private T value;
            public Node<T> NextNode { get; set; }
            public T Value { get => this.value; }
            public Node(T value, Node<T> nextNode = null)
            {
                this.value = value;
                this.NextNode = nextNode;
            }
        }
        private Node<T> firstNode;
        public int Count { get; private set; }
        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Peek()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            return this.firstNode.Value;
        }
        public T Pop() 
        {
            T item = this.Peek();

            this.firstNode = this.firstNode.NextNode;
            this.Count--;
            return item;
        }
        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int index = 0;
            Node<T> current = this.firstNode;

            while (current != null)
            {
                array[index] = current.Value;
                index++;
                current = current.NextNode;
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            T[] array = this.ToArray();
            foreach (var item in array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Contains(T item)
        {
            foreach (var element in this)
            {
                if(element.CompareTo(item) == 0)
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
                this.Pop();
            }
        }

    }
}
