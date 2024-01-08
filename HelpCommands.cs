using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class HelpCommands
    {
        public static void CommandsForDifferentUsers()
        {            
            Console.WriteLine("Now you can either register and become a member of the library or continue as a guest.");
            Console.WriteLine("Members can borrow and return books. Unregistered members (guests) can only browse the library catalogue.\n");
            Console.WriteLine("If you want to register or browse type \"Register\" or \"Browse\"");
        }

        public static void CommandsAfterDonation()
        {
            Console.WriteLine("You can type \"Quit\" to quit, you can also donate a book By typing \"Donate\".");
            Console.WriteLine("If you want to register or browse type \"Register\" or \"Browse\"");
            Console.WriteLine("\nWhat would you like to do next ?");
        }

        public static void CommandsForSorting()
        {
            Console.WriteLine("The books can be sorted in 4 ways : by title , author, number of pages and status.");
            Console.WriteLine("How would you like to sort them?");
        }

    }    
}
