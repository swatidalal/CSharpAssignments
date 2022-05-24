﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBasedLibraryMgmt
{
    public class Program
    {


        static void Main(string[] args)
        {
            //    //User obj = new User();
            //    //Console.WriteLine("user details");
            //    //obj.UserDetails();

            //    //Book obj1 = new Book();
            //    //Console.WriteLine("book details");
            //    //obj1.BookDetails();

            //    //Book obj2 = new Book();
            //    //Console.WriteLine(" Issue book details");
            //    //obj2.Issue();
            //    Administrator obj3 = new Administrator();
            //    Console.WriteLine(" Issue book details");
            //    obj3.ToIssueBook();

            //    Console.WriteLine();


            //}



            Console.WriteLine("---------------WELCOME TO LIBRARY MANAGEMENT SYSTEM---------------");
            Console.WriteLine("Please log in into any of the following account:");
            Console.WriteLine("1. Librarian");
            Console.WriteLine("2. Users");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());
            Librarian librarian = new Librarian();
            User users = new User();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("---------------WELCOME TO LIBRARIAN PORTAL---------------");
                    Console.WriteLine("");
                    Console.WriteLine("Please chooes one of the following action:");
                    Console.WriteLine("a. Add a book in the library.");
                    Console.WriteLine("b. Show the current available books in the library.");
                    Console.WriteLine("c. Show current inventory details.");
                    char choice1 = Convert.ToChar(Console.ReadLine());
                    switch (choice1)
                    {
                        case 'a':
                            Console.WriteLine("");
                            librarian.AddBookToTheLibrary();

                            break;
                        case 'b':
                            Console.WriteLine("");
                            librarian.ShowAvailableBooksInLibrary();

                            break;
                        case 'c':
                            Console.WriteLine("");
                            users.ShowInventoryDetails();

                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("\t\t---------------WELCOME TO USER PORTAL---------------\t\t");
                    Console.WriteLine("");
                    Console.WriteLine("Please chooes one of the following action:");
                    Console.WriteLine("a. Borrow a book from the library.");
                    Console.WriteLine("b. See currently available books");
                    char choice2 = Convert.ToChar(Console.ReadLine());
                    switch (choice2)
                    {
                        case 'a':
                            Console.WriteLine("");
                            users.BorrowBook();

                            break;
                        case 'b':
                            librarian.ShowAvailableBooksInLibrary();
                            break;
                    }
                    break;
            }
            }
        }
    }    

