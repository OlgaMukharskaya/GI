using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Book
    {

        public string Title { get; }
        public int Pages { get; }
        public string ID { get; }


        public Book(string title, int pages, string id)
        {
            Title = title;
            Pages = pages;
            ID = id;
        }

        public string GetBookInfo()
        {
            return String.Format("Title - {0}, Number of pages - {1}, BookID - {2}", Title, Pages, ID);
        }


    }

}

