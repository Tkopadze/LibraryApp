using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Library
    {
        int BookCount;
        private List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            BookCount++;
        }

        public void RemoveBook(string? title)

        {
            var toRemove = SearchBook(title);

            Books.Remove(toRemove);
            BookCount--;
        }

        public void DisplayAllBooks()
        {
            foreach(var book in Books)
            {
                
                System.Console.WriteLine({ book.Title});
                System.Console.WriteLine(book.Author);
        
                System.Console.WriteLine(book.CopiesAvailable);
            }
        }

        public Book SearchBook(string title)
        {
            
            foreach(var book in Books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }

     
    }
}
