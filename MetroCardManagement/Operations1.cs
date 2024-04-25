using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Partial class Operations used to create an instance of <see cref="Operations"/>
    /// </summary>
    public partial class Operations
    {
        //TravelHistory

        /// <summary>
        /// Methods TravelHistory is used to display the current users tarvel history <see cref="Operations"/>
        /// </summary>
        public static void TravelHistory()
        {
            //TravelDetails travel=travelList.Find(x=>x.CardNumber.Equals(currentLoggedInUser.CardNumber));
            TravelDetails travel = BinarySearch(travelList, currentLoggedInUser.CardNumber);
            if (travel == null)
            {
                Console.WriteLine("No travel details available as you not travelled.");
                return;
            }
            System.Console.WriteLine("|TravelID|CardNumber|FromLocation|ToLocation|Date|TravelCost|");
            foreach (TravelDetails travel1 in travelList)
            {
                if (travel1.CardNumber.Equals(currentLoggedInUser.CardNumber))
                {
                    System.Console.WriteLine($"|{travel1.TravelID}|{travel1.CardNumber}|{travel1.FromLocation}|{travel1.ToLocation}|{travel1.Date.ToString("dd/MM/yyyy")}|{travel1.TravelCost}");
                }
            }
        }
        //Travel history ends

        //Travel

        /// <summary>
        /// Methods Travel is used to book the metro ticket  <see cref="Operations"/>
        /// </summary>
        public static void Travel()
        {
            //Show ticket fair details
            System.Console.WriteLine("|TicketID|FromLocation|ToLocation|Fair|");
            foreach (TicketFairDetails ticketFair in ticketFairList)
            {
                System.Console.WriteLine($"|{ticketFair.TicketID}|{ticketFair.FromLocation}|{ticketFair.ToLocation}|{ticketFair.TicketPrice}");
            }
            //get the ticketID
            System.Console.WriteLine("Enter the ticketID you want: ");
            string ticketID = Console.ReadLine().ToUpper();
            //validate it
            if (ticketID != null)
            {
                //TicketFairDetails ticketFair=ticketFairList.Find(x=>x.TicketID.Equals(ticketID));
                TicketFairDetails ticketFair = BinarySearch(ticketFairList, ticketID);
                bool isFound = false;
                if (ticketFair != null)
                {
                    isFound = true;
                    //if valid 
                    //check the balance 
                    if (ticketFair.TicketPrice > currentLoggedInUser.Balance)
                    {
                        //if no ask him to recharge and go to submenu
                        System.Console.WriteLine("Please rechrge the wallet with  " + ticketFair.TicketPrice + " and proceed");
                        return;
                    }
                    //if yes duduct the amount and add travel details to travel history
                    currentLoggedInUser.Balance -= ticketFair.TicketPrice;
                    TravelDetails travel = new TravelDetails(currentLoggedInUser.CardNumber, ticketFair.FromLocation, ticketFair.ToLocation, DateTime.Now, ticketFair.TicketPrice);
                    travelList.Add(travel);
                    System.Console.WriteLine("Ticket purchased successfully.");
                    //if not display message
                }
                if (!isFound)
                {
                    System.Console.WriteLine("Invalid TicketID");
                }
            }

            //if valid 
            //check the balance 
            //if yes duduct the amount and add travel details to travel history
            //if no ask him to recharge and go to submenu
            //if not display message
        }
        //Travel ends

        /// <summary>
        /// BinarySearch method is used to search the elements in the list <see cref="Operations"/>
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cardNumber"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public static TravelDetails BinarySearch(CustomList<TravelDetails> list, string cardNumber)
        {
            int left = 0, right = list.Count - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (list[middle].CardNumber.Equals(cardNumber))
                {
                    return list[middle];
                }
                else if (string.Compare(list[middle].CardNumber, cardNumber) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

            }
            return null;
        }

        /// <summary>
        /// BinarySearch method is used to search the elements in the list <see cref="Operations"/>
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ticketID"></param>
        /// <returns></returns>
        public static TicketFairDetails BinarySearch(CustomList<TicketFairDetails> list, string ticketID)
        {
            int left = 0, right = list.Count - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (list[middle].TicketID.Equals(ticketID))
                {
                    return list[middle];
                }
                else if (string.Compare(list[middle].TicketID, ticketID) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

            }
            return null;
        }
    }
}