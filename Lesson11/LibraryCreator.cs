using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal static class LibraryCreator
    {
        internal static Library CreateLibrary(List<Book> books)
        {
            if ((books == null) || (books.Count == 0))
                throw new ArgumentException("books list is empty!");
            Console.WriteLine("Enter library name");
            var libName = Console.ReadLine();
            return (libName == "") ? new Library(books) : new Library(libName, books);
        }
    }
}
