namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Welcome To    ");
            Console.WriteLine(" +-+-+-+-+-+-+-+-+-+\r\n |W|h|a|t|I|s|F|u|n|\r\n +-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("Library Management System\nEnter your password: ");
            string password = Console.ReadLine();
            Library library = Library.Instance;

            // Books
            library.AddBook("AC-32692", "Shot for Mercy", "Mohd", "Shot for Mercy", 20);
            library.AddBook("AC-385472", "Shot for Mercy 2 ", "Mohd", "Shot for Mercy", 100);

            //Members
            library.AddMember("M-23H", "Mohammed", "Muscat", "+98262846");
            library.AddMember("M-53H", "Ahmed", "Sinow", "+98267476");

            if (password == "Mohd")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Invalid Password");
                Main(args);
            }

            void Menu() // To display The menu
            {
                LibraryMembers libraryMembers = new LibraryMembers(" "," "," "," ");
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
                        library.AddBook("AC-895592", "Shot for Mercy 4", "Mohd", "Shot for Mercy 4", 150);
                        break;
                    case 2:
                        library.AddMember("M-85L", "Salim", "Al Mawalih", "+98959554");
                        break;
                    case 3:
                        library.DisplayAllBooks();
                        break;
                    case 4:
                        library.DisplayAllMembers();
                        break;
                    case 5:
                        libraryMembers.Return();
                        break;
                    case 6:
                        libraryMembers.Borrow();
                        break;
                    case 7:
                        Console.WriteLine("Thank you");
                        Environment.Exit(0);   // To exit from the application
                        break;
                    default:
                        Console.WriteLine("Invalid option\nRetry !!!"); // If user entering invalid option the program will loop until enters a valid option or exit
                        Menu();
                        break;
                }

            }
        }
    }
}