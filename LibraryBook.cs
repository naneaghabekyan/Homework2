using System;

namespace LibraryBook
{
    internal class LibraryBook
    {
        public string Title {  get;private set; }
        public string Author { get;private set; }
        public int Year { get;private set; }

        public LibraryBook(): this ("", "", 0) { }
        public LibraryBook(string title, string author) : this(title, author, 0) { }
        public LibraryBook(string title, string author,int year ) 
        { 
            Title = title;
            Author = author;
            if (year > 2026)
            {
                Console.WriteLine("Year is set to 0 by default.");
            }
            else  
               Year = year;
        }

        public void ShowBook()
        {
            Console.WriteLine("Title:{0}",Title);
            Console.WriteLine("Author:{0}", Author);
            Console.WriteLine("Year:{0}\n", Year);
        }

    }
    internal class Program
{
    static void Main()
    {
        LibraryBook book1 = new LibraryBook();
        LibraryBook book2 = new LibraryBook("1984", "George Orwell");
        LibraryBook book3 = new LibraryBook("Dune", "Frank Herbert", 1965);

        book1.ShowBook();
        book2.ShowBook();
        book3.ShowBook();
    }
}
}
