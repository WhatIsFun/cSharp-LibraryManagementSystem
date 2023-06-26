namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome To WhatIsFun Library Management System!!!\nEnter your password :");
            string password = Console.ReadLine();

            if (password == "Mohd")
            {
                Console.WriteLine("Hello, World!");
                Library m = new Library();
                m.Menu();

            }
            else
            {
                Console.WriteLine("Invalid Password");
                Main(args);
            }
        }
    }
}