/* LibraryBook (Constructor chaining)
Գրիր class LibraryBook, որը․
● Ունի Title, Author, Year,
● Ունի 3 կոնստրուկտոր (default, 2-param, 3-param),
● Constructor chaining կիրառիր,
● Console demo՝ ստեղծիր տարբեր տարբերակներով և տպիր։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
