using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataTable dt = new DataTable();

            Console.WriteLine("********************************** Welcome to EVENT MANAGEMENT SYSTEM*******************************************");
            Console.WriteLine("Please Choose Profile to Continue :\n");
            Console.WriteLine("\t\tPress 1 For Super Admin");
            Console.WriteLine("\t\tPress 2 For Admin");
            Console.WriteLine("\t\tPress 3 For Customer");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SuperAdmin superAdmin = new SuperAdmin();

                    Console.WriteLine("************************Welcome to SuperAdmin Portal**************************************");
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress 1 to Insert Admin.");
                    Console.WriteLine("\t\tPress 2 to Update Admin.");
                    Console.WriteLine("\t\tPress 3 to Delete Admin.");
                    Console.WriteLine("\t\tPress 4 to Show All Admin Table Data.");
                    Console.WriteLine("\t\tPress 5 to Show a Particular Admin Data.");

                    int choice1 = Convert.ToInt32(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            string result = superAdmin.InsertAdmin();
                            Console.WriteLine(result);
                            break;
                        case 2:
                            result = superAdmin.UpdateAdmin();
                            Console.WriteLine(result);
                            break;
                        case 3:
                            Console.WriteLine("\nEnter The Admin ID to Delete :");
                            int AdminId = Convert.ToInt32(Console.ReadLine());
                            result = superAdmin.DeleteAdmin(AdminId);
                            Console.WriteLine(result);
                            break;
                        case 4:
                            Console.WriteLine();
                            dt = superAdmin.ShowAdmin();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter The AdminId To See Its Details : ");
                            int AdminId1 = Convert.ToInt32(Console.ReadLine());
                            dt = superAdmin.SelectAdminById(AdminId1);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == AdminId1)
                                {
                                    {
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {

                                            Console.Write(dt.Rows[i][j] + "\t\t");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;

                    }

                    break;


               

                case 2:

                    Admin admin = new Admin();

                    Admin:
                    Console.WriteLine("***********************WeCome to Admin Portal*******************************");
                    Console.WriteLine("Press 1 for Adding Event");
                    Console.WriteLine("Press 2 for Adding FoodItem");
                    Console.WriteLine("Press 3 for Adding Decoration Type ");
                    Console.WriteLine("Press 4 for Displaying all Bookings");

                    

                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            string result = admin.AddEvent();
                            Console.WriteLine(result);
                            break;
                        case 2:
                            result = admin.AddFoodItems();
                            Console.WriteLine(result);
                            break;
                        case 3:
                            result = admin.AddDecoration();
                            Console.WriteLine(result);
                            break;
                        case 4:
                            admin.DisplayAllBookings();
                            Console.WriteLine();
                            break;

                    }

                    goto Admin;

                    break;
                   



                case 3:


                    Customer customer = new Customer();
                    Console.WriteLine("*****************************Welcome to Customer Portal***************************************");
                    Console.WriteLine("Press 1 to Show All Events");
                    Console.WriteLine("Press 2 for Booking Event");
                   Customer:
                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    switch (choice3)
                    {
                        case 1:
                            customer.DisplayAllEvents();
                            Console.WriteLine();
                            goto Customer;
                            break;

                        case 2:
                            Console.WriteLine(customer.BookEvent());
                            Console.WriteLine();
                            goto Customer;
                            break;

                    }

                    break;



            }

            Console.ReadLine();


        }
    }
}


