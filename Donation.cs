using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Donation
    {
        public static void DonatingBooks()
        {
            bool isValid = false;
            int booksForDonation = 0;

            Console.WriteLine("How many books will you donate?");

            while (!isValid)
            {
                try
                {
                    booksForDonation = int.Parse(Console.ReadLine());

                    if (booksForDonation <= 0)
                    {
                        Console.WriteLine("Enter a number greater than 0");
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a number.");
                }
            }
           

            for (int i = 0; i < booksForDonation; i++)
            {
                Book newBook = new Book();                

                Console.WriteLine("What is the title of the book?");
                string title = Console.ReadLine();
                newBook.Title = title;

                Console.WriteLine("Who is the author of the book?");
                string author = Console.ReadLine();
                newBook.Author = author;

                Console.WriteLine("How many pages does the book have?");
                int pages = int.Parse(Console.ReadLine());
                newBook.Pages = pages;

                newBook.AvailabilityStatus = "Available.";                
                BookRepository.DefaultList.Add(newBook);

                Console.WriteLine("Thank you for your donation. Your book had been added to our library.\n");
                Console.WriteLine($"All available books:");
                BookRepository.PrintList(BookRepository.DefaultList);
                
            }
        }
    }

}


