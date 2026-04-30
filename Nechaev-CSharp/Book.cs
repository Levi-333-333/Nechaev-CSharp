using System;
using System.Collections.Generic;
using System.Text;

namespace Books_namespace
{
    internal abstract class Books
    {
        public abstract string Name {  get; }
        public abstract string Author { get; }
        public abstract uint Year { get; }
        public abstract string Genre { get; }
        public abstract uint PagesCount { get; }
        public abstract bool Availability { get; }
        public abstract void PrintInfo();
    }
    class Book : Books
    {
        private string name;
        private string author;
        private uint year;
        private string gengre;
        private uint pagesCount;
        private bool availability;

        public Book(string name, string author, uint year, string gengre, uint pagesCount, bool availability)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.gengre = gengre;
            this.pagesCount = pagesCount;
            this.availability = availability;
        }

        public override string Name
        {
            get { return name; }
        }
        public override string Author 
        {
            get { return author; }
        }
        public override uint Year
        {
            get { return year;}
        }
        public override string Genre
        {
            get { return gengre; }
        }
        public override uint PagesCount
        {
            get { return pagesCount; }
        }
        public override bool Availability
        {
            get { return availability; }
        }
        public override void PrintInfo()
        {
            Console.Write($"{Name}: {Author}. {Year}. {Genre}. Кол-во страниц: {PagesCount}. ");
            if (availability == true) Console.WriteLine("Книга доступна");
            else Console.WriteLine("Книга недоступна");
        }
    }
}
