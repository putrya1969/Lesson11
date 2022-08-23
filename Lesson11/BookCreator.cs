using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public static class BookCreator
    {
        internal static Book CreateBook(string booksString)
        {
            Book book = null;
            var booksAttr = booksString.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string genre = "";
            if (booksAttr.Length == 3)
                genre = GetGeneralGenre(booksAttr[booksAttr.Length - 1]);
            switch (booksAttr.Length)
            {
                case 1:
                    {
                        book = new Book(booksAttr[0]);
                        break;
                    }
                case 2:
                    {
                        book = new Book(booksAttr[0], booksAttr[1]);
                        break;
                    }
                case 3:
                    {
                        book = new Book(booksAttr[0], booksAttr[1], genre);
                        break;
                    }
            }
            return book;
        }

        private static string GetGeneralGenre(string bookGenres)
        {
            return bookGenres.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Cast<string>().Select(s => s.Substring(2, s.Length - 3)).FirstOrDefault();
        }
    }
}
