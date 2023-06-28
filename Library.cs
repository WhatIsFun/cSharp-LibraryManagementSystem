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
        // Books
        List<Book> books = new List<Book>();
        
        Book book1 = new Book("AC-32692", "Shot for Mercy", "Mohd", "Shot for Mercy", 20);
        Book book2 = new Book("AC-385472", "Shot for Mercy 2 ", "Mohd", "Shot for Mercy", 100);

        //Members

        LibraryMembers member1 = new LibraryMembers("M-23H", "Mohammed", "Muscat", "+98262846");
        LibraryMembers member2 = new LibraryMembers("M-53H", "Ahmed", "Sinow", "+98267476");
        //string[,,,] books = []
        internal void Menu() // To display The menu
        {
            Console.WriteLine("\nMenu\n" +
                    "1)Add book\n" +
                    "2)Add library member\n" +
                    "3)Display all books\n" +
                    "4)Display all library members\n" +
                    "5)Return book\n" +
                    "6)Borrow book\n" +
                    "7)Exit\n");
            Console.Write("Choose your option from menu :");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //addBook();
                    break;
                case 2:
                    //addLibraryMember();
                    break;
                case 3:
                    displayAllBooks();
                    break;
                case 4:
                    displayAllLibraryMembers();
                    break;
                case 5:
                    returnBook();
                    break;
                case 6:
                    borrowBook();
                    break;
                case 7:
                    Console.WriteLine("Thank you");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option\nRetry !!!");
                    Menu();
            }
        }



    }
    internal void displayAllBooks()
    {
        Console.WriteLine();
    }


}
