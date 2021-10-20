using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book()
            {
                bookId = 1,
                bookTitle = "The sun",
                bookAuthor = "Mahira"
            };
            Book b2 = new Book()
            {
                bookId = 2,
                bookTitle = "The Moon",
                bookAuthor = "Mahira"
            };


            Book b = new Book();
            b.print(b1);

            Console.Read();
        }
    }
}
