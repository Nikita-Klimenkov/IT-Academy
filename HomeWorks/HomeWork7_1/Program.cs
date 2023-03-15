using System;
using static HomeWork7_1.Book;

namespace HomeWork7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddedBook += Notify;

            Reader reader0 = new Reader(0);
            Reader reader1 = new Reader(1);

            library.readers.Add(reader0);
            library.readers.Add(reader1);

            reader0.Subscribe(Genres.History);
            reader0.Subscribe(Genres.Biography);
            reader1.Subscribe(Genres.GraphicNovel);

            Book book0 = new Book("adv_book", Genres.History);
            Book book1 = new Book("det_book", Genres.GraphicNovel);
            Book book3 = new Book("mys_book", Genres.Biography);

            library.AddBooks(book0);
            library.AddBooks(book0);
            library.AddBooks(book1); ;
            library.AddBooks(book3);
            library.AddBooks(book0);

            void Notify(Genres genre)
            {
                foreach (var reader in library.readers)
                {
                    if (reader.subscribes[genre])
                    {
                        Console.WriteLine($"Reader(UserID: {reader.Id}) was notified.");
                    }
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}