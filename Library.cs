using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System
{
    internal class Library
    {
        //Program program = new Program(); // To make the program back to menu 

        private static Library instance;

        public static Library Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Library();
                }
                return instance;
            }
        }

        private List<Book> books;
        private List<LibraryMembers> members;

        private Library()
        {
            books = new List<Book>();
            members = new List<LibraryMembers>();
        }
        public void AddBook(string ISBN, string Title, string Auther, string Description, int AvailableCopies) // this funtion to add books to the library
        {
            Book book = new Book(ISBN,Title, Auther, Description, AvailableCopies);
            //Console.Write("Enter the book ISBN: ");
            //string isbn = Console.ReadLine();
            //Console.Write("Enter the book title: ");
            //string title = Console.ReadLine();
            //Console.Write("Enter the book auther: ");
            //string auther = Console.ReadLine();
            //Console.Write("Enter the book description: ");
            //string description = Console.ReadLine();
            //Console.Write("Enter the book available copies: ");
            //string availableCopies = Console.ReadLine();
            books.Add(book);

            
        }
        public void AddMember(string memberId, string name, string address, string phoneNumber) // this funtion to add members to the library
        {
            LibraryMembers member= new LibraryMembers(memberId, name, address, phoneNumber);

            members.Add(member);
        }

        public void DisplayAllBooks()  // this funtion to display all books in the library
        {
            Console.WriteLine("-_-_- All Books -_-_-");
            foreach (var book in books)   //var will take on each value stored in list in turn
            {
                book.bookDetails();
            }
        }

        public void DisplayAllMembers() // this funtion to display all members in the library
        {
            Console.WriteLine("-_-_- All Members -_-_-");
            foreach (var member in members)
            {
                member.memberDetails();
            }
        }
        
        public Book FindBook(string title)  // this funtion to find books by name and ISBN in the library
        {
            return books.Find(b => b.Title == title);
        }
    }
}
