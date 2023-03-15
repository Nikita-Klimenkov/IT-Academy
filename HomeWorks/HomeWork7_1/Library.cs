using System;
using System.Collections.Generic;
using static HomeWork7_1.Book;

namespace HomeWork7_1
{
    public class Library
    {
        private List<Book> _books = new List<Book>();
        public List<Reader> readers = new List<Reader>();

        public delegate void AddBook(Genres genre);

        public event AddBook AddedBook;

        public void AddBooks(params Book[] books)
        {
            foreach (var book in books)
            {
                _books.Add(book);

                Console.WriteLine($"Library: Added new book - \"{book.Title}\"(Genre - {book.Genre})");

                AddedBook(book.Genre);
            }
        }
    }
}