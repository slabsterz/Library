using System;

namespace Library
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to donate a book?");
            string input = Console.ReadLine().ToLower();
            int stateCounter = 0;

            while (input != "quit")
            {                
                if (stateCounter == 0)
                {
                    if (input.StartsWith("y") || input.Contains("don"))
                    {
                        Donation.DonatingBooks();
                        HelpCommands.CommandsAfterDonation();
                    }                 
                    else if (input.StartsWith("n") || input.Contains("no") || input.Contains("reg") || input.Contains("brow"))
                    {
                        if (input.Contains("no"))
                        {
                            HelpCommands.CommandsForDifferentUsers();
                            input = Console.ReadLine();
                            stateCounter = 1;
                        }                    
                    }                                 
                         
                    if (stateCounter == 1)
                    {
                        string reaction = input;
                        if (reaction.Contains("reg"))
                        {
                            LibraryOperations.RegisterAMember();
                        }
                        else if (reaction.Contains("brow") || reaction.Contains("cata"))
                        {
                            BookRepository.PrintList(BookRepository.DefaultList);

                            HelpCommands.CommandsForSorting();

                            string sortingWay = Console.ReadLine()!;

                            if (sortingWay.Contains("title"))
                            {
                                SortingBooks.SortBooksByTitle();
                            }
                            else if (sortingWay.Contains("author"))
                            {
                                SortingBooks.SortBooksByAuthor();
                            }
                            else if (sortingWay.Contains("pages"))
                            {
                                SortingBooks.SortBooksByPages();
                            }
                            else if (sortingWay.Contains("status"))
                            {
                                SortingBooks.SortBooksByStatus();
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
            
        }
    }
}
