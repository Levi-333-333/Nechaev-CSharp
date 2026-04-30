using System;
using System.Collections.Generic;
using System.Text;
using Books_namespace;
using Exceptions_namespace;

namespace Libruary_namespace
{
    public delegate void DelegateLutiy(string message);
    internal class Libruary
    {
        private List<Books> books;
        public event DelegateLutiy BookAdded;
        public Libruary(List<Books> books) => this.books = books;
        public void AddBook(Books book)
        {
            this.books.Add(book);
            BookAdded?.Invoke("Книга была добавлена.");
        }
        public List<Books> SearchBookName(string name)
        {
            List<Books> returnList = new List<Books> { };
            foreach (Books book in this.books) if (book.Name == name) returnList.Add(book);
            if (returnList.Count != 0) return returnList;
            else throw new BookNotFoundEcxeption();
        }
        public List<Books> SearchBookAuthor(string author)
        {
            List<Books> returnList = new List<Books> { };
            foreach (Books book in this.books) if (book.Author == author) returnList.Add(book);
            if (returnList.Count != 0) return returnList;
            else throw new BookNotFoundEcxeption();
        }
        public void DeleteBook(string name)
        {    
            foreach (Books book in this.books) if (book.Name == name) books.Remove(book);
        }
    }
}
