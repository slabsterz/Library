using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SortingBooks
    {
        public static void SortBooksByTitle()
        {
            BookRepository books = new BookRepository();
            StringBuilder sb = new StringBuilder();

            var sortedByName = BookRepository.DefaultList.OrderBy( x => x.Title);

            foreach ( var book in sortedByName )
            {
                sb.AppendLine($"Title: {book.Title}, Author: {book.Author},Pages: {book.Pages},Status: {book.AvailabilityStatus}").ToString();
            }
            Console.WriteLine(sb);

        }

        public static void SortBooksByAuthor()
        {
            BookRepository books = new BookRepository();
            StringBuilder sb = new StringBuilder();

            var sortedByAuthor = BookRepository.DefaultList.OrderBy(x => x.Author);

            foreach (var book in sortedByAuthor)
            {
                sb.AppendLine($"Author: {book.Author}, Title: {book.Title},Pages: {book.Pages},Status: {book.AvailabilityStatus}").ToString();
            }
            Console.WriteLine(sb);
        }

        public static void SortBooksByPages()
        {
            BookRepository books = new BookRepository();
            StringBuilder sb = new StringBuilder();

            var sortedByAuthor = BookRepository.DefaultList.OrderBy(x => x.Pages);

            foreach (var book in sortedByAuthor)
            {
                sb.AppendLine($"Pages: {book.Pages}, Title: {book.Title},Author: {book.Author},Status: {book.AvailabilityStatus}").ToString();                
            }
            Console.WriteLine(sb);
        }

        public static void SortBooksByStatus()
        {
            BookRepository books = new BookRepository();
            StringBuilder sb = new StringBuilder();

            var sortedByAuthor = BookRepository.DefaultList.OrderBy(x => x.AvailabilityStatus);

            foreach (var book in sortedByAuthor)
            {
                sb.AppendLine($"Status: {book.AvailabilityStatus}, Title: {book.Title},Author: {book.Author},Pages: {book.Pages}").ToString();
            }
            Console.WriteLine(sb);
        }
    }
}
