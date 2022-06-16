using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    public class SuperAdmin
    {
        public static string sqlConnectionStr = @"Data Source =SWATI; Initial Catalog=EventManagement;Integrated Security=True";

        public string InsertAdmin()
        {
            Console.WriteLine("Enter Admin Id:-");
            int AdminId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Admin  Name:-");
            string AdminName = Console.ReadLine();

            Console.WriteLine("Enter the Role:");
            string Role= Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Admin values(" + AdminId + ",'" + AdminName + "','" + Role + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not inserted";
            return "inserted";

            
        }

        public string UpdateAdmin()
        {
            Console.WriteLine("Enter Admin ID to Update:-");
            int AdminId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Admin Name to update:-");
            string AdminName = Console.ReadLine();

            Console.WriteLine("Enter the Role:-");
            string Role = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Admin set  AdminName = '" + AdminName + "', Role = '" + Role + "' where  AdminId = " + AdminId + "  ", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";



            

        }

        public string DeleteAdmin(int AdminId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Admin where AdminId=" + AdminId, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
            Console.Read();

        }

        public DataTable ShowAdmin()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Admin", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;


        }

        public DataTable SelectAdminById(int AdminId)
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Admin where AdminId = " +AdminId+" ", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;

        }

    }
}
