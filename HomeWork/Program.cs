using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Book Book1 = new Book("BookName-1", 11, "8bde16de-7ce5");
            Book Book2 = new Book("BookName-2", 222, "e062cacd-a56c");
            Book Book3 = new Book("BookName-3", 3, "061ab441-9f71");
            Book Book4 = new Book("BookName-4", 44, "23344637-0d35");
            Book Book5 = new Book("BookName-5", 555, "137c348e-56d5");

            Book[] Books = { Book1, Book2, Book3, Book4, Book5 };

            foreach (Book item in Books)
            {
                Console.WriteLine(item.GetBookInfo());
            }

            //создать класс Книга (в нем название (строка), количество страниц (int), уникальный идентификатор (строка)..
            //Создайте массив книг (5 штук) проинициализируйте его различными объектами типа "Книга",
            //и выведите информацию о всех книгах в массиве на экран

        }
    }
}