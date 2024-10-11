using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BookManager
    {
        internal List<Book> books = new List<Book>();


        public void CreateBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully");
        }


        public void ReadBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public void UpdateBook(int id,string title, string author, decimal rentalPrice)
        {
            var book = books.FirstOrDefault(b=>b.BookId == id);
            if (book != null)
            {
                book.BookId = id;
                book.Title = title;
                book.Author = author;
                book.RentalPrice = rentalPrice;
                Console.WriteLine("Book updated successfully.");
            }
            else
            {
                Console.WriteLine("Book not Found.");
            }
            
        }

        public void DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b=>b.BookId==id);
            if(book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }



    }
}
