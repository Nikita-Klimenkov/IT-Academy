using System;

namespace HomeWork6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] library =
            {
                new Book("Cтивен Хокинг", 3525),
                new Book("Мир животных", 1246),
                new Magazine("Наука", 50),
                new Book("Дисковери", 456),
                new Magazine("Инженерия", 236),
                new Magazine("Биология", 123),
                new Book("Химия", 1246),
            };

            Console.WriteLine("Вся библиотека:");
            
            foreach (var book in library)
            {
                book.Print();
            }

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Все книги:");
            Book.PrintBook(library);
            
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Все журналы:");
            Magazine.PrintMagazine(library);
        }
    }

    public class Book : IPrintable
    {
        private string Name { get; set; }
        
        private int Pages { get; set; }

        public Book(string name, int pages)
        {
            Name = name;
            Pages = pages;
        }
        
        public static void PrintBook(IPrintable[] printable)
        {
            foreach (var print in printable)
            {
                if (print is Book book)
                {
                    book.Print();
                }
            }
        }
        
        public void Print()
        {
            Console.WriteLine($"Книга называется - {Name}, имеет {Pages} страниц.");
        }
    }
    
    public class Magazine : IPrintable
    {
        private string Name { get; set; }
        
        private int Pages { get; set; }
        
        public Magazine(string name, int pages)
        {
            Name = name;
            Pages = pages;
        }
        
        public static void PrintMagazine(IPrintable[] printable)
        {
            foreach (var print in printable)
            {
                if (print is Magazine magazine)
                {
                    magazine.Print();
                }
            }
        }
        
        public void Print()
        {
            Console.WriteLine($"Журнал называется - {Name}, имеет {Pages} страниц.");
        }
    }
    
    public interface IPrintable
    {
        public void Print();
    }
}