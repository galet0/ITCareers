using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DynamicList
{
    public class DynamicList<T> where T : IComparable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;
        private class Node<T>
        {
            private T item;
            private Node<T> next;
            public Node(T item)
            {
                this.Item = item;
            }
            public Node(T item, Node<T> prevNode)
            {
                this.Item = item;
                prevNode.Next = this;
            }
            public T Item
            {
                get { return item; }
                set { item = value; }
            }
            public Node<T> Next
            {
                get { return next; }
                set { next = value; }
            }

        }

        public int Count { get => this.count; }

        public T this[int index]
        {
            get
            {
                int currentIndex = 0;
                Node<T> current = this.head;

                while (current != null)
                {
                    if(index == currentIndex)
                    {
                        return current.Item;
                    }
                    currentIndex++;
                    current = current.Next;
                }

                return default;
            }
            set
            {
                int currentIndex = 0;
                Node<T> current = this.head;

                while (current != null)
                {
                    if (index == currentIndex)
                    {
                        current.Item = value;
                    }

                    current = current.Next;
                }
            }
        }
        public void Add(T item)
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
            this.count++;
        }

        public int IndexOf(T item)
        {
            int index = 0;
            Node<T> current = this.head;

            while (current != null)
            {
                if(current.Item.CompareTo(item) == 0)
                {
                    return index;
                }
                else
                {
                    current = current.Next;
                    index++;
                }
            }

            return -1;
        }
        public T RemoveAt(int index)
        {
            int i = 0;
            Node<T> current = this.head;
            Node<T> prev = null;

            if(index == 0)
            {
                this.head = this.head.Next;
                this.count--;
                return current.Item;
            }

            while (current != null)
            {
                if(index == i)
                {
                    this.count--;
                    if (current == this.tail)
                    {
                        this.tail = prev;
                        this.tail.Next = null;
                        return current.Item;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;
                        prev.Next = current.Next;
                        break;
                    }
                }

                prev = current;
                current = current.Next;
                i++;
            }

            return current.Item;
        }
        public int Remove(T item)
        {
            int index = this.IndexOf(item);

            if(index != -1)
            {
                this.RemoveAt(index);
            }

            return index;
        }

        public bool Contains(T item)
        {
            return this.IndexOf(item) != -1 ? true : false;
        }


    }


}
