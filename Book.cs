using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management_System
{
    internal class Book
    {
        public string ISBN { get; }
        public string Title;
        public string Author;
        public string Description;
        public int AvailableCopies;

        public Book(string ISBN, string Title, string Auther, string Description, int AvailableCopies) 
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Auther;
            this.Description = Description;
            this.AvailableCopies = AvailableCopies;
        }
        internal void bookDetails()
        {
            Console.WriteLine("-_-_- Book Detais -_-_-");
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Available Copies: {AvailableCopies}");
        }

        internal void copiesUpdate() 
        {

        }

    }

}
