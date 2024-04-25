using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// 
    /// Class  CartItem used to select instance for cartItems <see cref="CartItem"/><
    /// 
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// 
        /// static field s_itemID used to autoincrement ItemID of the instance of <see cref="CartItem"/>
        /// 
        /// </summary>
        private static int s_itemID=100;
        // •	ItemID (Auto - ITID101) 
        // •	OrderID
        // •	FoodID
        // •	OrderPrice
        // •	OrderQuantity

        /// <summary>
        /// 
        /// ItemID property used to hold a item ID of the instance <see cref="CartItem"/>
        /// 
        /// </summary>
        /// <value></value>
        public string ItemID { get;  }  

        /// <summary>
        /// OrderID property used to hold a Order ID of the instance <see cref="CartItem"/>
        /// </summary>
        /// <value></value>
        public string OrderID { get; set; }
        /// <summary>
        /// 
        /// Food property used to hold a Food id of the instance <see cref="CartItem"/>
        /// 
        /// </summary>
        /// <value></value>
        public string FoodID { get; set; }

        /// <summary>
        /// 
        /// OrderPrice property used to hold a Order price of the instance <see cref="CartItem"/>
        /// 
        /// </summary>
        /// <value></value>
        public double OrderPrice { get; set; }

        /// <summary>
        /// OrderQuantity property used to hold a order quantity of the instance <see cref="CartItem"/>
        /// </summary>
        /// <value></value>
        public int OrderQuantity { get; set; }

        /// <summary>
        /// Parametrized CartItem used to initialize parameter values to its properties
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="foodID"></param>
        /// <param name="orderPrice"></param>
        /// <param name="quantity"></param> <summary>
        /// 
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="foodID"></param>
        /// <param name="orderPrice"></param>
        /// <param name="quantity"></param>
        public CartItem(string orderID,string foodID, double orderPrice,int quantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=quantity;
        }

        public CartItem(string cartItem)
        {
            string[] values=cartItem.Split(",");
            ItemID=values[0];
            s_itemID=int.Parse(values[0].Remove(0,4));
            OrderID=values[1];
            FoodID=values[2];
            OrderPrice=double.Parse(values[3]);
            OrderQuantity=int.Parse(values[4]);
        }
    }
}