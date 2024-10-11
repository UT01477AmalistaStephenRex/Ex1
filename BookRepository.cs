using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class BookRepository
    {
        public void CreateBook(Book book) { }
        public List<Book> ReadBooks() 
        {
            List<Book> books = new List<Book>();
            { }
        }
        public void UpdateBook(int bookId,Book book) { }
        public void DeleteBook(int bookId) { }
    }
}
