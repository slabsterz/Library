using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public string AvailabilityStatus { get; set; }

        public Book() { }
     

        public Book(string title, string author, int pages, string availability) 
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.AvailabilityStatus = availability;
           // List<Book> books = BookRepository.DefaultList;
        }

        public void GetBookInfo()
        {
            Console.WriteLine($"Book Title: {Title}, Book author: {Author}, Book Pages: {Pages}");
        }

        public void UpdateAvalability(string status)
        {
            this.AvailabilityStatus = status;
        }
    }
}
