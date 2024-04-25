using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicketBooking"))
            {
                System.Console.WriteLine("Creating folder..");
                Directory.CreateDirectory("MovieTicketBooking");
            }

            if(!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/BookingDetails.csv").Close();
            }

            if(!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/MovieDetails.csv").Close();
            }

            if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/ScreeningDetails.csv").Close();
            }

            if(!File.Exists("MovieTicketBooking/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/TheatreDetails.csv").Close();
            }

            if(!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicketBooking/UserDetails.csv").Close();
            }
        }

        public static void WriteToCSV()
        {
            string[] bookings=new string[Program.bookingDetailsList.Count];
            for(int i=0;i<Program.bookingDetailsList.Count;i++)
            {
                bookings[i]=Program.bookingDetailsList[i].BookingID+","+Program.bookingDetailsList[i].UserID+","+Program.bookingDetailsList[i].MovieID+","+Program.bookingDetailsList[i].TheatreID+","+Program.bookingDetailsList[i].SeatCount+","+Program.bookingDetailsList[i].TotalAmount+","+Program.bookingDetailsList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv",bookings);

            string[] movies=new string[Program.movieDetailsList.Count];
            for(int i=0;i<Program.movieDetailsList.Count;i++)
            {
                movies[i]=Program.movieDetailsList[i].MovieID+","+Program.movieDetailsList[i].MovieName+","+Program.movieDetailsList[i].Language;
            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv",movies);

            string[] screenings=new string[Program.screeningDetailsList.Count];
            for(int i=0;i<Program.screeningDetailsList.Count;i++)
            {
                screenings[i]=Program.screeningDetailsList[i].MovieID+","+Program.screeningDetailsList[i].TheatreID+","+Program.screeningDetailsList[i].TicketPrice+","+Program.screeningDetailsList[i].NoOfSeats;
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screenings);

            string[] theatres=new string[Program.theatreDetailsList.Count];
            for(int i=0;i<Program.theatreDetailsList.Count;i++)
            {
                theatres[i]=Program.theatreDetailsList[i].TheatreID+","+Program.theatreDetailsList[i].TheatreName+","+Program.theatreDetailsList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicketBooking/TheatreDetails.csv",theatres);


            string[] users=new string[Program.userDetailsList.Count];
            for(int i=0;i<Program.userDetailsList.Count;i++)
            {
                users[i]=Program.userDetailsList[i].UserID+","+Program.userDetailsList[i].Name+","+Program.userDetailsList[i].Age+","+Program.userDetailsList[i].PhoneNumber+","+Program.userDetailsList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv",users);



        }

        public static void ReadFromCSV()
        {
            string[] bookings=File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            foreach(string booking in bookings)
            {
                BookingDetails newBooking=new BookingDetails(booking);
                Program.bookingDetailsList.Add(newBooking);
            }

            string[] movies=File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            foreach(string movie in movies)
            {
                MovieDetails newMovie=new MovieDetails(movie);
                Program.movieDetailsList.Add(newMovie);
            }

            string[] screenings=File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            foreach(string screening in screenings)
            {
                ScreeningDetails newScreening=new ScreeningDetails(screening);
                Program.screeningDetailsList.Add(newScreening);
            }

            string[] theatres=File.ReadAllLines("MovieTicketBooking/TheatreDetails.csv");
            foreach(string theatre in theatres)
            {
                TheatreDetails newTheatre=new TheatreDetails(theatre);
                Program.theatreDetailsList.Add(newTheatre);
            }

            string[] users=File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails newUser=new UserDetails(user);
                Program.userDetailsList.Add(newUser);
            }
        }
    }
}