using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Book
    {
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal string Genre { get; set; }

        internal Book(string title) : this(title, "unknown") { }
        internal Book(string title, string author) : this(title, author, "unavailable ") { }
        internal Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        internal void PrintContent()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}");
        }
    }
}
