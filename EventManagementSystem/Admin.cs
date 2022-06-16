using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    public class Admin
    {

        public static string sqlConnectionStr = @"Data Source =SWATI; Initial Catalog=EventManagement;Integrated Security=True";
        

        public string AddEvent()
        {
            Console.WriteLine("Enter EventId Id:-");
            int EventId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EventName  Name:-");
            string EventName = Console.ReadLine();

            Console.WriteLine("Enter the Venue of Event:");
            string EventVenue = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Event values(" + EventId + ",'" + EventName + "','" + EventVenue + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
            return "Not Added";
            return "Added";

        }

        public string AddFoodItems()
        {
            Console.WriteLine("Enter FoodItem Id:-");
            int FoodItemId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Food Item Name:-");
            string FooditemName = Console.ReadLine();

            Console.WriteLine("Enter the Cost Food Item:");
            int FoodItemCost = Convert.ToInt32(Console.ReadLine());



            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into FoodItem values(" + FoodItemId + ",'" + FooditemName + "'," + FoodItemCost + ")", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
            return "Not Added";
            return "Added";

        }

        public string AddDecoration()
        {
            Console.WriteLine("Enter Decoration Id:-");
            int DecorationId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Decoration Type:-");
            string DecorationType = Console.ReadLine();

            Console.WriteLine("Enter the Cost Decoration:");
            int DecorationCost = Convert.ToInt32(Console.ReadLine());



            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Decoration values(" + DecorationId + ",'" + DecorationType + "'," + DecorationCost + ")", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Added";
            return "Added";

        }


        public void DisplayAllBookings()
        {
            Admin obj = new Admin();
            DataTable dt = obj.ShowAllBookings();
            Console.WriteLine("CId\tCName\t\tCAddrs \t Mobile\tEventName\tFoodIds\tDId\tTPerson\tEventCost");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public DataTable ShowAllBookings()
        {
            #region disconnected-mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection stablishmentg
            SqlDataAdapter sda = new SqlDataAdapter("select * from Customer ", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            #endregion
        }





    }
}
