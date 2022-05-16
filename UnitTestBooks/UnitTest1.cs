using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Task_10;
using System.Linq;
using System;


namespace Tas10_UnitTests
{
    [TestClass]
    public class UnitTestBooks
    {
        [TestMethod]
        public void SortBooksByTitle()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Kameron", "Becker", 1895, 000));
            authors.Add(new Author("Gunner", "Burton", 1970, 001));
            authors.Add(new Author("Marcos", "Schaefer", 1990, 002));
            authors.Add(new Author("Gunner", "Jackson", 1990, 003));
            authors.Add(new Author("Josh", "Hubbard", 1975, 004));
            authors.Add(new Author("Kameron", "Schaefer", 1941, 005));

            Catalogue Libriary = new Catalogue();
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


            Book[] ExpectedResult = { Libriary.Books[0], Libriary.Books[6], Libriary.Books[1], Libriary.Books[8], Libriary.Books[9], Libriary.Books[3], Libriary.Books[7], Libriary.Books[2], Libriary.Books[4], Libriary.Books[5] };

            List<Book> sortByTitle = Libriary.SortByTitle();
            CollectionAssert.AreEqual(sortByTitle, ExpectedResult);
        }

        [TestMethod]
        public void SortByAuthorLastName()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Kameron", "Becker", 1895, 000));
            authors.Add(new Author("Gunner", "Burton", 1970, 001));
            authors.Add(new Author("Marcos", "Schaefer", 1990, 002));
            authors.Add(new Author("Gunner", "Jackson", 1990, 003));
            authors.Add(new Author("Josh", "Hubbard", 1975, 004));
            authors.Add(new Author("Kameron", "Schaefer", 1941, 005));

            Catalogue Libriary = new Catalogue();
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


            Author[] ExpectedResult = { authors[0], authors[1], authors[5], authors[2], authors[3], authors[4] };

            List<Author> allAuthors = Libriary.GetAuthors();
            CollectionAssert.AreEqual(allAuthors, ExpectedResult);
        }

        [TestMethod]
        public void BooksOfOneAuthor()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Kameron", "Becker", 1895, 000));
            authors.Add(new Author("Gunner", "Burton", 1970, 001));
            authors.Add(new Author("Marcos", "Schaefer", 1990, 002));
            authors.Add(new Author("Gunner", "Jackson", 1990, 003));
            authors.Add(new Author("Josh", "Hubbard", 1975, 004));
            authors.Add(new Author("Kameron", "Schaefer", 1941, 005));

            Catalogue Libriary = new Catalogue();
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


            Book[] ExpectedResult = { Libriary.Books[9] };

            List<Book> oneAuthor = Libriary.OneAuthor("Kameron", "Schaefer", 2010);
            CollectionAssert.AreEqual(oneAuthor, ExpectedResult);
        }

        [TestMethod]
        public void SortAuthorsByDateOfBirth()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Kameron", "Becker", 1895, 000));
            authors.Add(new Author("Gunner", "Burton", 1970, 001));
            authors.Add(new Author("Marcos", "Schaefer", 1990, 002));
            authors.Add(new Author("Gunner", "Jackson", 1990, 003));
            authors.Add(new Author("Josh", "Hubbard", 1975, 004));
            authors.Add(new Author("Kameron", "Schaefer", 1941, 005));

            Catalogue Libriary = new Catalogue();
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


            Author[] ExpectedResult = { authors[0], authors[5], authors[1], authors[4], authors[2], authors[3] };

            List<Author> sortByDOB = Libriary.SortByDOB();
            CollectionAssert.AreEqual(sortByDOB, ExpectedResult);
        }
    }
}

