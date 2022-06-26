using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_04072021
{
    public class Book
    {
        private string id;
        private Book next;

        public Book(string id)
        {
            this.Id = id;
        }
        public Book(string id, Book prev)
        {
            this.Id = id;
            prev.Next = this;
        }
        public string Id
        {
            get { return id; }
            private set { id = value; }
        }
        public Book Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"Book: {this.Id}";
        }
    }
}
