using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class LibraryProcessor
    {
        internal static Library Library { get; set; }
        public LibraryProcessor(Library library)
        {
            Library = library;
        }

        internal string[] GetGenres()
        {
            return Library.Books.Select(b => b.Genre).Distinct().OrderBy(g => g).ToArray();
        }
        internal List<Book> GetBooksByGenre(string genre)
        {
            return Library.Books.Where(b => b.Genre == genre).ToList();
        }

        internal void PrintOrder(List<Book> books)
        {
            foreach (var item in books)
            {
                Console.WriteLine(new string('-', 30));
                item.PrintContent();
            }
        }

        internal void PrintInstruction()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Welcome to our library '{Library.Name}'\nWe have in stock {Library.Books.Count} books!!!");
            sb.AppendLine("To work with library, enter the following characters");
            sb.AppendLine("To view genres our books, enter:     'V'");
            sb.AppendLine("To view all books, enter:            'B'");
            sb.AppendLine("To view books by genre data, enter:  'G'");
            sb.AppendLine("To exit the program, enter:          'X'");
            Console.Clear();
            Console.WriteLine(sb);
        }

        internal void ProcessInput(string userSelect)
        {
            Console.Clear();
            switch (userSelect)
            {
                case "v":
                    {
                        GetGenres().PrintArray();
                        break;
                    }
                case "b":
                    {
                        PrintOrder(Library.Books);
                        break;
                    }
                case "g":
                    {
                        Console.WriteLine("Enter genre:");
                        var genre = Console.ReadLine();
                        if (!GetGenres().Contains(genre))
                            Console.WriteLine("Enter invalid genre");
                        PrintOrder(GetBooksByGenre(genre));
                        break;
                    }
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
