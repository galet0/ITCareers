using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_04072021
{
    public class Shelf
    {
        private Book head;
        private Book tail;
        private int count;

        public int Count => this.count;

        public Shelf()
        {

        }
        public void AddBook(string bookId)
        {
            Book newBook = null;
            if(this.count == 0)
            {
                newBook = new Book(bookId);
                this.head = this.tail = newBook;
            }
            else
            {
                newBook = new Book(bookId, this.tail);
                this.tail = newBook;
            }

            this.count++;
        }

        public void AddSpecialBook(string bookId)
        {
            Book book = new Book(bookId);

            if(this.Count == 0)
            {
                this.AddBook(bookId);
            }
            else
            {
                book.Next = head;
                this.head = book;
                this.count++;
            }
        }

        public Book CheckBookIsPresent(string bookId)
        {
            Book currentBook = this.head;

            while(currentBook != null)
            {
                if(currentBook.Id == bookId)
                {
                    return currentBook;
                }

                currentBook = currentBook.Next;
            }

            return null;
        }

        public bool ReleaseBook(string bookId)
        {
            Book currentBook = this.head;
            int index = 0;

            while (currentBook != null)
            {
                if(currentBook.Id == bookId)
                {
                    return this.ReleaseBook(index);
                }

                currentBook = currentBook.Next;
                index++;
            }

            return false;
        }

        public bool ReleaseBook(int index)
        {
            bool isValid = CheckIndex(index);
            if (!isValid) return false;

            Book currentBook = this.head;
            Book prevBook = null;
            int currentIndex = 0;

            while (currentBook != null)
            {
                if(currentIndex == index)
                {
                    if(prevBook == null)
                    {
                        this.head = this.head.Next;
                    }
                    else
                    {
                        if(index == this.Count - 1)
                        {
                            this.tail = prevBook;
                            this.tail.Next = null;
                        }
                        else
                        {
                            prevBook.Next = currentBook.Next;
                        }
                    }

                    this.count--;

                    return true;
                }
                currentIndex++;
                prevBook = currentBook;
                currentBook = currentBook.Next;
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

        public StringBuilder ShelfInformation()
        {
            StringBuilder sb = new StringBuilder();
            Book currentBook = this.head;

            while (currentBook != null)
            {
                sb.AppendLine(currentBook.ToString());

                currentBook = currentBook.Next;
            }

            return sb;
        }

    }
}
