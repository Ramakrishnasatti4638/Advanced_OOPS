using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Class TravelDetails used to  create the instance of <see cref="TravelDetails"/>
    /// </summary>
    public class TravelDetails
    {
        /// <summary>
        /// Static field s_travel_ID used to autoincrement when it is called <see cref="TravelDetails"/>
        /// </summary>
        private static int s_travelID = 2000;
        // Properties:
        // a.	TravelId (Auto Generated -TID2001)
        // b.	Card Number
        // c.	FromLocation
        // d.	ToLocation
        // e.	Date
        // f.	Travel Cost

        /// <summary>
        /// Porperty TravelID holds the travelID of instance of <see cref="TravelDetails"/>
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string TravelID { get; }

        /// <summary>
        /// Property CardNumber holds the cardNumber value of the instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <value></value>
        public string CardNumber { get; set; }
        /// <summary>
        /// Property FromLocation holds the Fromlocation value of the instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <value></value>

        public string FromLocation { get; set; }
        /// <summary>
        /// Property ToLocation holds the Tolocation value of the instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <value></value>

        public string ToLocation { get; set; }
        /// <summary>
        /// Property Date holds the date value of the instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <value></value>

        public DateTime Date { get; set; }
        /// <summary>
        /// Property TravelCost holds the cost value of the instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <value></value>

        public int TravelCost { get; set; }

        /// <summary>
        /// Parametrized constructor  TravelDetails used to assign values to properties <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        /// <param name="date"></param>
        /// <param name="travelCost"></param> <summary>
        /// 
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        /// <param name="date"></param>
        /// <param name="travelCost"></param>
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, int travelCost)
        {
            s_travelID++;
            TravelID = "TID" + s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }

        /// <summary>
        /// Parametrized constructor  TravelDetails used to assign values to properties from file <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="travel"></param>
        public TravelDetails(string travel)
        {
            string[] values = travel.Split(",");
            TravelID = values[0];
            s_travelID = int.Parse(values[0].Remove(0, 3));
            CardNumber = values[1];
            FromLocation = values[2];
            ToLocation = values[3];
            Date = DateTime.ParseExact(values[4], "dd/MM/yyyy", null);
            TravelCost = int.Parse(values[5]);
        }

    }
}