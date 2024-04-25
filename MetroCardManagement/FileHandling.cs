using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Class Filehandling used to create an instance of <see cref="FileHandling"/>
    /// </summary>
    public class FileHandling
    {
        /// <summary>
        /// Methods Create is used to create the folder and files of instance of <see cref="FileHandling"/>
        /// </summary>
        public static void Create()
        {
            //creating directory
            if (!Directory.Exists("MetroCardManagement"))
            {
                System.Console.WriteLine("Craeting folder..");
                Directory.CreateDirectory("MetroCardManagement");
            }

            //Craeting User details file
            if (!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating file..");
                File.Create("MetroCardManagement/UserDetails.csv").Close();
            }

            //Creating file for TicketFair details
            if (!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                System.Console.WriteLine("Creating file..");
                File.Create("MetroCardManagement/TicketFairDetails.csv").Close();
            }

            //Creating file for Travel details
            if (!File.Exists("MetroCardManagement/TravelDetails.csv"))
            {
                System.Console.WriteLine("Creating file..");
                File.Create("MetroCardManagement/TravelDetails.csv").Close();
            }
        }

        /// <summary>
        /// Method writeToCSV used to write the data to the csv file of instance of <see cref="FileHandling"/>
        /// </summary>
        public static void WriteToCSV()
        {
            //writing to userdetails
            string[] users = new string[Operations.userList.Count];
            for (int i = 0; i < Operations.userList.Count; i++)
            {
                users[i] = Operations.userList[i].CardNumber + "," + Operations.userList[i].UserName + "," + Operations.userList[i].PhoneNumber + "," + Operations.userList[i].Balance;
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv", users);

            //writing to Ticketfairdetails
            string[] fairs = new string[Operations.ticketFairList.Count];
            for (int i = 0; i < Operations.ticketFairList.Count; i++)
            {
                fairs[i] = Operations.ticketFairList[i].TicketID + "," + Operations.ticketFairList[i].FromLocation + "," + Operations.ticketFairList[i].ToLocation + "," + Operations.ticketFairList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardManagement/TicketFairDetails.csv", fairs);

            //writing to TravelDetails
            string[] travels = new string[Operations.travelList.Count];
            for (int i = 0; i < Operations.travelList.Count; i++)
            {
                travels[i] = Operations.travelList[i].TravelID + "," + Operations.travelList[i].CardNumber + "," + Operations.travelList[i].FromLocation + "," + Operations.travelList[i].ToLocation + "," + Operations.travelList[i].Date.ToString("dd/MM/yyyy") + "," + Operations.travelList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardManagement/TravelDetails.csv", travels);
        }

        /// <summary>
        /// Method ReadFromCSV used to read the data from the csv files of instance of <see cref="FileHandling"/>
        /// </summary>
        public static void ReadFromCSV()
        {
            //Read from userDetails.csv
            string[] users = File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach (string user in users)
            {
                UserDetails user1 = new UserDetails(user);
                Operations.userList.Add(user1);
            }

            //Read from TicketFairDetails.csv
            string[] fairs = File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            foreach (string fair in fairs)
            {
                TicketFairDetails fair1 = new TicketFairDetails(fair);
                Operations.ticketFairList.Add(fair1);
            }

            //Read from TravelDetails.csv
            string[] travels = File.ReadAllLines("MetroCardManagement/TravelDetails.csv");
            foreach (string travel in travels)
            {
                TravelDetails travel1 = new TravelDetails(travel);
                Operations.travelList.Add(travel1);
            }
        }
    }
}