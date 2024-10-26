using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Library
    {
      
        private List<Book> Books { get; set; }
        private int BookCount;
        public Library()
        {
            Books = new List<Book>();
            BookCount = 0;
           
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            BookCount++;
            Console.WriteLine($"{book.Title} დაემატა ბიბლიოთეკას.");
        }

        public void RemoveBook(string? title)

        {
            var toRemove = SearchBook(title);
            if (toRemove != null)
            {
                Books.Remove(toRemove);
                BookCount--;
                Console.WriteLine($"{title} წაიშალა ბიბლიოთეკიდან.");
            }
            else
            {
                Console.WriteLine("წიგნის არ მოიძებნა.");
            }
        }

        public void DisplayAllBooks()
        {
            if (BookCount == 0) {
                Console.WriteLine("ბიბლიოთეკა ცარიელია.");

            }
            else
            {
                Console.WriteLine("ბიბლიოთეკაში არსებული წიგნების სია: ");

                foreach (var book in Books)
                {
                    Console.WriteLine($"სახელი: {book.Title}");
                    Console.WriteLine($"ავტორი: {book.Author}");
                    Console.WriteLine($"რაოდენობა: {book.CopiesAvailable}");
                }
            }
            
        }

        public Book SearchBook(string title)
        {
    
          
            foreach(var book in Books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine($" {book.Title} წარმატებით მოიძებნა");
                    return book;
                }

            }
            Console.WriteLine("წიგნი არ მოიძებნა.");
            return null;
        }

     
    }
}
