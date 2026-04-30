using System;
using System.Diagnostics;
using Libruary_namespace;
using Books_namespace;
 
namespace Nechaev_CSharp
{
    class Source
    {
        string whoIsMe = "я редиска";
        static void ShowMessage(string message) => Console.WriteLine(message);

        static void Main(string[] args)
        {
            try
            {
                Libruary libruary = new Libruary(new List<Books>());
                libruary.BookAdded += ShowMessage;
                libruary.AddBook(new Book("фывфыв", "авав", 2026, "Философия", 132, true));
                libruary.AddBook(new Book("фывфыв2", "авав", 2026, "Философия", 184, false));
                libruary.AddBook(new Book("Исскоство языка Си", "Сунь Дзы", 4, "Техническая", 1268, false));
                libruary.AddBook(new Book("Отруби", "Валентин Касевьев Омарович", 2000, "Фантастика", 23, true));

                Console.WriteLine("\nПоиск по названию");
                foreach (Books book in libruary.SearchBookName("фывфыв")) book.PrintInfo();
                Console.WriteLine("\nПоиск по автору");
                foreach (Books book in libruary.SearchBookAuthor("авав")) book.PrintInfo();
                Console.WriteLine("\nОшибка в имени автора");
                foreach (Books book in libruary.SearchBookAuthor("Сунь си")) book.PrintInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}