using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OnlineCinemaTicketBookingSystem
{
    internal class User
    {
        string customerName, movieName,location;
        public int customerId;
        // DateTime issueDate;

        Admin admin = new Admin();
        public void BookMovie()
        {
            Console.WriteLine("Enter Your name");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter Your  customer Id");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the movie name you want to book.");
            movieName = Console.ReadLine();

            Console.WriteLine("Enter the location where you want to book movie.");
            movieName = Console.ReadLine();


            admin .StoreCustomerDetails( customerName,customerId,movieName,location);
            Console.WriteLine("Thanks for booking.");
            Console.WriteLine("Have a nice day!");


        }

    }
}
