using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management_System
{
    internal class Book : ILendable
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int AvailableCopies { get; set; }

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

        public void Borrow()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Sorry, the book is not available for borrowing.");
            }
        }

        public void Return()
        {
            AvailableCopies++;
            Console.WriteLine("Book returned successfully.");
        }
    }

}
