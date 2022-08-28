using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            var fileHeper = new FileHelper(Path.Combine(Environment.CurrentDirectory, "books.txt"));
            foreach (var item in fileHeper.FileContent)
            {
                books.Add(BookCreator.CreateBook(item));
            }
            var library = LibraryCreator.CreateLibrary(books);
            var libraryProcessor = new LibraryProcessor(library);
            bool repeatIt = false;
            do
            {
                libraryProcessor.PrintInstruction();
                var userInputHandler = new UserInputHandler();
                try
                {
                    userInputHandler.CheckInput(Console.ReadLine());
                    libraryProcessor.ProcessInput(userInputHandler.UserInput);
                    repeatIt = true;
                }
                catch (InvalidUserInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    repeatIt = userInputHandler.Iterate;
                }
                catch (UserHaltException ex)
                {
                    Console.WriteLine(ex.Message);
                    repeatIt = false;
                }
            } while (repeatIt);
            Console.WriteLine("For continue press any key...");
            Console.ReadKey();
        }
    }
}
//checked
