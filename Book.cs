using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Book
    {
        public int BookId {  get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal RentalPrice { get; set; }

        public Book(int bookId, string title, string author, decimal rentalPrice)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }
    }
}
