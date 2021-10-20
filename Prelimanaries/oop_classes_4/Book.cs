using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes_4
{
    class Book
    {
        public int bookId { get; set; }
        public string bookTitle { get; set; }
        public string bookAuthor { get; set; }

        public void print(Book b)
        {
            Console.WriteLine(b);
        }

        public override string ToString()
        {
            return "Book Title: " + this.bookTitle;
        }

    }
}
