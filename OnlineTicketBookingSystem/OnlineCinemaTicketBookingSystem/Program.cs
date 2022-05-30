using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OnlineCinemaTicketBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Admin admin = new Admin();
           // admin.AddMoviesToPortal();
            //Console.WriteLine(" showw movie details");
            admin.ShowAvailableMoviesonPortal();
            // Console.ReadLine();

            Console.WriteLine("---------------WELCOME TO ONLINE MOVIE TICKET BOOKING SYSTEM---------------");
            Console.WriteLine("Please log in into any of the following account:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Users");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());
            Admin admin1 = new Admin();
            User users = new User();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("---------------WELCOME TO ADMIN PORTAL---------------");
                    Console.WriteLine("");
                    Console.WriteLine("Please chooes one of the following action:");
                    Console.WriteLine("a. Add a Movie to the portal .");
                    Console.WriteLine("b. Show the current available Movies on the Portal.");
                    //Console.WriteLine("c. Show current inventory details.");
                    char choice1 = Convert.ToChar(Console.ReadLine());
                    switch (choice1)
                    {
                        case 'a':
                            Console.WriteLine("");
                            admin1.AddMoviesToPortal();

                            break;
                        case 'b':
                            Console.WriteLine("");
                           
                            admin1.ShowAvailableMoviesonPortal();
                            Console.ReadLine();

                            break;
                            
                    }
                    break;
                case 2:
                    Console.WriteLine("\t\t---------------WELCOME TO USER PORTAL---------------\t\t");
                    Console.WriteLine("");
                    Console.WriteLine("Please chooes one of the following action:");
                    Console.WriteLine("a. Book a movie on the portal.");
                    Console.WriteLine("b. See currently available movies");
                    char choice2 = Convert.ToChar(Console.ReadLine());
                    switch (choice2)
                    {
                        case 'a':
                            Console.WriteLine("");
                            users.BookMovie();
                            Console.ReadLine();
                           

                            break;
                        case 'b':

                            Console.WriteLine("");
                            admin1.ShowAvailableMoviesonPortal();
                            Console.ReadLine();
                            break;
                    }
                    break;
            }
        }
    }
}    
        
    

