using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class LibraryOperations
    {
        public static void CheckOutBook(Book book, LibraryMember member)
        {
            member.BorrowBook(book);
            book.AvailabilityStatus = "Not present in the system.";
        }

        public static void ReturnBook(Book book, LibraryMember member)
        {
            member.ReturnBook(book);
            book.AvailabilityStatus = "Book is available.";
        }

        public static void ShowLibraryMembers()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (LibraryMember members in LibraryMember.LibraryMembers)
            {
                stringBuilder.AppendLine($"Name: {members.FirstName}, {members.LastName},ID: {members.MemberID},Books borrowed: {members.BooksBorrowed}");
            }
            
            Console.WriteLine(stringBuilder.ToString());
        }     

        public static void RegisterAMember()
        {
            LibraryMember member = new LibraryMember();

            Console.Clear();
            Console.WriteLine("What is your first name ?");
            string createUserFirstName = Console.ReadLine();
            member.FirstName = createUserFirstName;

            Console.WriteLine("What is your last name ?");
            string createUserLastName = Console.ReadLine();
            member.LastName = createUserLastName;
            LibraryMember.LibraryMembers.Add(member);

            member.DisplayMemberInfo();
        }

        public static void UnregisterAMember(LibraryMember member) 
        {           
            LibraryMember.LibraryMembers.Remove(member);
        }
     
    }
}
