using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Library
    {
        internal string Name { get; set; }

        private List<Book> _books;

        internal List<Book> Books
        {
            get { return _books; }
            private set 
            {
                if ((value == null) || (value.Count == 0))
                    throw new Exception("List of books - empty!");
                _books = value; 
            }
        }

        internal Library(List<Book> books) : this("noname", books) { }
        internal Library(string libraryName, List<Book> books)
        {
            Name = libraryName;
            Books = books;
        }

    }
}
