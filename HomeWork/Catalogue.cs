using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Catalogue
    {
        public List<Book> Books { get; }
        public Catalogue()
        {
            Books = new List<Book>();
        }


        public void SortByTitle()
        {
            Console.WriteLine("List of Books sorted by Title: ");
            var bytitle = Books.OrderBy(x => x.Title);
            foreach (var book in bytitle)
            {
                Console.WriteLine($"{book.Title} - {book.PublishingYear}");
            }
        }

        public void AllAuthors()
        {
            Console.WriteLine("List of Authors from the Catalogue:");
            var allauthours = Books.SelectMany(x => x.Authors).Distinct();
            foreach (var book in allauthours)
            {
                Console.WriteLine($"{book.FirstName} {book.LastName}");
            }
        }

        public void OneAuthor(string firstname, string lastname, int publishing)
        {
            Console.WriteLine("Books by Author " + firstname + " " + lastname + " published after " + publishing);
            var byauthror = Books.Where(x => x.Authors.Any(x => x.FirstName == firstname && x.LastName == lastname)).Where(x => x.PublishingYear > publishing);
            foreach (var book in byauthror)
            {
                Console.WriteLine($"{book.Title} - {book.PublishingYear}");
            }
        }

        public void SortByDOB()
        {
            Console.WriteLine("List of Authors sorted by Date of Birth: ");
            var bydateofbirth = Books.SelectMany(x => x.Authors).OrderBy(x => x.DateOfBirth).Distinct();
            foreach (var book in bydateofbirth)
            {
                Console.WriteLine($"{book.DateOfBirth} - {book.FirstName} {book.LastName}");
            }

        }
    }
}