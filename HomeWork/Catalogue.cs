using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    public class Catalogue


    {
        private List<Book> Libriary { get; set; }
        public Catalogue(List<Book> books)
        {
            this.Libriary = books;
        }

        public Catalogue()
        {
            this.Libriary = new List<Book>();
        }

        public List<Book> Books
        {
            get
            {
                return this.Libriary;
            }
            set
            {
                this.Libriary = value;
            }
        }

        public void AddNewBook(string title, List<Author> authors, int publishing, int bookid)
        {
            var result = Books.Find(x => x.BookID == bookid);

            if (result == null)
            {
                Books.Add(new Book(title, authors, publishing, bookid));
            }
            else
            {
                throw new Exception("The book Exists in the Catalogue");
            }
        }

        public List<Book> SortByTitle()
        {
            var bytitle = Books.OrderBy(x => x.Title).ToList();
            return bytitle;
        }

        public List<Author> GetAuthors()
        {
            var authors = Books.SelectMany(b => b.Authors).Distinct().ToList();
            return authors;
        }

        public List<Book> OneAuthor(string firstname, string lastname, int publishing)
        {
            var byauthor = Books.Where(x => x.Authors.Any(x => x.FirstName == firstname && x.LastName == lastname)).Where(x => x.PublishingYear > publishing).ToList();
            return byauthor;

        }
        public List<Author> SortByDOB()
        {
            var authors = Books.SelectMany(x => x.Authors).OrderBy(x => x.DateOfBirth).Distinct().ToList();
            return authors;
        }
    }
}

