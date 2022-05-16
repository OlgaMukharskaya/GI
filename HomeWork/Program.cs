using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task_10
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Author> authors = new List<Author>();

            authors.Add(new Author("Kameron", "Becker", 1895, 000));
            authors.Add(new Author("Gunner", "Burton", 1970, 001));
            authors.Add(new Author("Marcos", "Schaefer", 1990, 002));
            authors.Add(new Author("Gunner", "Jackson", 1990, 003));
            authors.Add(new Author("Josh", "Hubbard", 1975, 004));
            authors.Add(new Author("Kameron", "Schaefer", 1941, 005));


            Catalogue Libriary = new Catalogue();
            //List<Book> books = new List<Book>();
            Libriary.Books.Add(new Book("Galley Minor", new List<Author>() { authors[0] }, 1925, 258541258));
            Libriary.Books.Add(new Book("Laviscounts", new List<Author>() { authors[0] }, 2013, 654782236));
            Libriary.Books.Add(new Book("Rabbit Habbit", new List<Author>() { authors[1], authors[5] }, 2005, 654125896));
            Libriary.Books.Add(new Book("Monokle Point", new List<Author>() { authors[2] }, 2020, 212587452));
            Libriary.Books.Add(new Book("Red Head", new List<Author>() { authors[3] }, 1923, 321452365));
            Libriary.Books.Add(new Book("Red Head", new List<Author>() { authors[3] }, 2008, 321452365));
            Libriary.Books.Add(new Book("Jenny Island", new List<Author>() { authors[4] }, 1988, 125874521));
            Libriary.Books.Add(new Book("Neck of Land", new List<Author>() { authors[4], authors[5] }, 2001, 645829971));
            Libriary.Books.Add(new Book("Little Bird", new List<Author>() { authors[5] }, 2001, 374412586));
            Libriary.Books.Add(new Book("Little Bird", new List<Author>() { authors[5] }, 2016, 712365547));


            //Libriary.AddNewBook("Little Bird", new List<Author>() { authors[5] }, 2016, 712365547);


            foreach (Book item in Libriary.SortByTitle()) ;

            foreach (Author item in Libriary.GetAuthors()) ;

            foreach (Book item in Libriary.OneAuthor("Kameron", "Schaefer", 2010)) ;

            foreach (Author item in Libriary.SortByDOB()) ;

        }
    }
}
