using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    
    internal class LibraryMembers : ILendable
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public LibraryMembers(string MemberId, string Name, string Address, string PhoneNumber) 
        {
            this.MemberId = MemberId;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            BorrowedBooks = new List<Book>();
        }
        internal void memberDetails() // To Display member details 
        {
            Console.WriteLine("-_-_- Member Detais -_-_-");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Id: {MemberId}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member PhoneNumber: {PhoneNumber}");
        }
        //internal void bookTrack() // To track the books borrowed by the member.
        //{

        //}

        public void Borrow()
        {
            Console.WriteLine("Enter the Title of the book you want to borrow:");
            string title = Console.ReadLine();
            Book book = Library.Instance.FindBook(title);

            if (book != null)
            {
                book.Borrow();
                BorrowedBooks.Add(book);
                Console.WriteLine("Book added to your borrowed books list.");
            }
            else
            {
                Console.WriteLine("No book with the provided title found.");
            }
        }

        public void Return()
        {
            Console.WriteLine("Enter the title of the book you want to return:");
            string title = Console.ReadLine();
            Book book = BorrowedBooks.Find(b => b.Title == title);

            if (book != null)
            {
                book.Return();
                BorrowedBooks.Remove(book);
                Console.WriteLine("Book removed from your borrowed books list.");
            }
            else
            {
                Console.WriteLine("You have not borrowed a book with the provided title.");
            }
        }
    }
}
