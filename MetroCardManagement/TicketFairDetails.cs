using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{

    /// <summary>
    /// Class TicketFairDetails used to create the instance of <see cref="TicketFairDetails"/>
    /// </summary>
    public class TicketFairDetails
    {
        /// <summary>
        /// static field s_ticketID used to autoincrement the value when class is called <see cref="TicketFairDetails"/>
        /// </summary>
        private static int s_ticketID = 3000;
        // Properties:
        // •	TicketID (Auto Generated – MR3001)
        // •	FromLocation
        // •	ToLocation
        // •	TicketPrice

        /// <summary>
        /// Property TicketID used to hold the ticketID of instance <see cref="TicketFairDetails"/> 
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string TicketID { get; }

        /// <summary>
        /// Property FromLocations holds the from location value of instance <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value></value>
        public string FromLocation { get; set; }

        /// <summary>
        /// Property ToLocation holds the tolocation values of instance <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value></value>
        public string ToLocation { get; set; }

        /// <summary>
        /// Property TicketPrice holds the price value of the instance <see cref="TicketFairDetails"/>
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int TicketPrice { get; set; }


        /// <summary>
        /// Parametrized constructed used to assign values to the properties <see cref="TicketFairDetails"/>
        /// </summary>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        /// <param name="ticketPrice"></param>


        public TicketFairDetails(string fromLocation, string toLocation, int ticketPrice)
        {
            s_ticketID++;
            TicketID = "MR" + s_ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }


        /// <summary>
        /// Parametrized constructor used to assign the values to the properties from file of instance <see cref="TicketFairDetails"/>
        /// </summary>
        /// <param name="fair"></param>
        public TicketFairDetails(string fair)
        {
            string[] values = fair.Split(",");
            TicketID = values[0];
            s_ticketID = int.Parse(values[0].Remove(0, 2));
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice = int.Parse(values[3]);
        }

    }
}