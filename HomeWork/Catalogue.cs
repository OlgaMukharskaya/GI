using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Catalogue
    {
        public List<Book> Books { get; set; }


        public void SortByTitle()
        {
            Console.WriteLine("List of Books sorted by Title: ");
            var bytitle = Books.OrderBy(x => x.Title).ToList();
            bytitle.ForEach(x => Console.WriteLine(x.Title + " - " + x.PublishingYear));
        }

        public void AllAuthors()
        {
            Console.WriteLine("List of Authors from the Catalogue:");
            var allauthours = Books.SelectMany(x => x.Authors).ToList();
            allauthours.ForEach(x => Console.WriteLine(x.LastName + ", " + x.FirstName));
        }

        public void OneAuthor(string firstname, string lastname, int publishing)
        {
            Console.WriteLine("Books by Author " + firstname + " " + lastname + " published after " + publishing);
            var byauthror = Books.Where(x => x.Authors.Any(x => x.FirstName == firstname && x.LastName == lastname)).Where(x => x.PublishingYear > publishing).ToList();
            byauthror.ForEach(x => Console.WriteLine(x.Title));
        }

        public void SortByDOB()
        {
            Console.WriteLine("List of Authors sorted by Date of Birth: ");
            var bydateofbirth = Books.SelectMany(x => x.Authors).OrderBy(x => x.DateOfBirth).ToList();
            bydateofbirth.ForEach(x => Console.WriteLine(x.DateOfBirth + " - " + x.FirstName + " " + x.LastName));
        }

    }

}
