using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// 
    /// DataType OrderStatus used to select instance of <see cref="OrderDetails"/>
    /// 
    /// </summary>
    public enum OrderStatus{Default,Initiated,Ordered,Cancelled}
    
    /// <summary>
    /// 
    /// Class OrderDetails used to create instance of order <see cref="OrderDetails"/>
    /// 
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// 
        /// static filed s_orderID used to autoincrement  OrderIDof the instance of <see cref="OrderDetails"/>
        /// 
        /// </summary>
        private static int s_orderID=1000;
        // •	OrderID (Auto – OID1001)
        // •	UserID
        // •	OrderDate
        // •	TotalPrice
        // •	OrderStatus – (Default, Initiated, Ordered, Cancelled)
        public string OrderID { get; set; }
        /// <summary>
        /// 
        /// UserID properrty used to hold the userID of the instance of <see cref="OrderDetails"/>
        /// 
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// 
        /// OrderDate properrty used to hold the Orde date of the instance of <see cref="OrderDetails"/>
        /// 
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Total Price properrty used to hold the TotalPrice of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }

        /// <summary>
        /// OrderStatus properrty used to hold the Orderstatus of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Pramaetrized constructor OrderDetails used to initialize parameters value to its properties
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="orderDate"></param>
        /// <param name="totalPrice"></param>
        /// <param name="orderStatus"></param> <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="orderDate"></param>
        /// <param name="totalPrice"></param>
        /// <param name="orderStatus"></param>
        public OrderDetails(string userID,DateTime orderDate,double totalPrice,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }

        public OrderDetails(string order)
        {
            string[] values=order.Split(",");
            OrderID=values[0];
            s_orderID=int.Parse(values[0].Remove(0,3));
            UserID=values[1];
            OrderDate=DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
            TotalPrice=double.Parse(values[3]);
            OrderStatus=Enum.Parse<OrderStatus>(values[4]);
        }

    }
}