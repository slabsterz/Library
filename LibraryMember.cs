using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryMember
    {
        public string MemberID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; } 

        public List<Book> BooksBorrowed { get; set; }

        public static List<LibraryMember> LibraryMembers { get; set; }
       

        public LibraryMember()
        {
            this.MemberID = GenerateRandomID(4);          
            BooksBorrowed = new List<Book>();
            LibraryMembers = new List<LibraryMember>();
        }

        public void BorrowBook(Book book)
        {
            this.BooksBorrowed.Add(book);
            BookRepository.DefaultList.Remove(book);
        }

        public void ReturnBook(Book book)
        {
            this.BooksBorrowed.Remove(book);
            BookRepository.DefaultList.Add(book);

        }

        public void DisplayMemberInfo()
        {
            Console.Clear();
            Console.WriteLine("You are: ");
            Console.WriteLine($"Member name: {FirstName} {LastName}, Member ID: {MemberID}, You've borrowed: {BooksBorrowed.Count} books.");
        }

        static string GenerateRandomID(int lenght)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < lenght; i++)
            {
                int index = rnd.Next(validChars.Length);
                sb.Append(validChars[index]);
            }

            return sb.ToString();
        }
    }
}

