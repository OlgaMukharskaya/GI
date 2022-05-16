using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    public class Book
    {

        public string Title { get; set; }
        public int PublishingYear { get; set; }
        public List<Author> Authors { get; set; }
        public int BookID;
        public Book(string title, List<Author> authors, int publishing, int bookid)
        {
            Title = title;
            Authors = authors;
            PublishingYear = publishing;
            BookID = bookid;
        }
    }
}
