using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnlineCinemaTicketBookingSystem
{
    public class Admin
    {
        string MovieName, MovieProdutionHouse;
        int movieId;
        string location, bookingDate;
        public void AddMoviesToPortal()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\LENOVO\Desktop\Training\MovieTicketBooking\movieDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            int counter = 1, totalMovies;
            Console.WriteLine("Enter total number Of Movies you want to Add to  the Portal");
            totalMovies = Convert.ToInt32(Console.ReadLine());


            while (counter <= totalMovies)
            {

                Console.WriteLine("Enter Movie ID");
                movieId = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(movieId + ",");

                Console.WriteLine("Enter Movie name.");
                MovieName = Console.ReadLine();
                streamWriterObj.Write(MovieName + ",");

                Console.WriteLine("Enter Movie Theatre Location");
                location = Console.ReadLine();
                streamWriterObj.Write(location + ",");

                Console.WriteLine("Enter Movie ProductionHouse name.");
                MovieProdutionHouse = Console.ReadLine();
                streamWriterObj.WriteLine(MovieProdutionHouse);

                counter++;
            }
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");

        }


        //Showing movies available on portal


        public void StoreCustomerDetails(String customerName, int customerId, string movieName, string location)
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\LENOVO\Desktop\Training\MovieTicketBooking\bookingDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            streamWriterObj.Write(customerName + ",");

            streamWriterObj.Write(customerId + ",");

            streamWriterObj.Write(movieName + ",");
            streamWriterObj.Write(location);


            bookingDate = DateTime.Now.ToShortDateString();
            streamWriterObj.WriteLine(bookingDate);

            streamWriterObj.Close();
            fileStreamObj.Close();

            Console.WriteLine("File write operation completed");


        }
        public void ShowAvailableMoviesonPortal()
        {

            try
            {


                if (File.Exists(@"C: \Users\LENOVO\Desktop\Training\MovieTicketBooking\movieDetails.txt"))
                {
                    Console.WriteLine("No Movie added yet");
                }
                else
                {
                    Console.WriteLine("file exits");

                    FileStream fileStreamObj = new FileStream(@"C:\Users\LENOVO\Desktop\Training\MovieTicketBooking\movieDetails.txt", FileMode.Open, FileAccess.Read);
                    StreamReader streamReaderObj = new StreamReader(fileStreamObj);
                    Console.WriteLine("MovieId\t\tMovieName\t\t\tlocation\tProductionHouse");
                    while (streamReaderObj.Peek() > 0)
                    {
                        string line = streamReaderObj.ReadLine();
                        string[] movieDataArr = line.Split(',');

                        for (int i = 0; i < movieDataArr.Length; i++)
                        {
                            Console.Write(movieDataArr[i] + "\t\t");
                            if (i == 1)
                            {
                                Console.Write("\t\t");
                            }
                        }
                        Console.WriteLine("");
                    }
                    streamReaderObj.Close();
                    fileStreamObj.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR 404");
                using (FileStream fileStreamObj2 = new FileStream(@"C:\Users\LENOVO\Desktop\Training\MovieTicketBooking\Log.txt", FileMode.Append, FileAccess.Write))
                {
                    StreamWriter streamWriterObj = new StreamWriter(fileStreamObj2);
                    streamWriterObj.Write("Date : " + DateTime.Now.ToString() + " ");
                    streamWriterObj.Write("Message : " + ex.Message + " ");
                    streamWriterObj.WriteLine("StackTrace : " + ex.StackTrace + " ");


                }
            }

        }
    }
}
