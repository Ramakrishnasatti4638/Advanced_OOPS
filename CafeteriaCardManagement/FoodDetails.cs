using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// 
    /// Class FoodDetails used to create instance for  food <see cref="FoodDetails"/>
    /// 
    /// </summary>
    public class FoodDetails
    {
        /// <summary>
        /// 
        /// static field s_foodID used to autoincrement FoodID of the instance <see cref="FoodDetails"/>
        /// 
        /// </summary>
        private static int s_foodID=100;
        // •	FoodID (Auto - FID101)
        // •	FoodName
        // •	FoodPrice
        // •	AvailableQuantity

        /// <summary>
        /// 
        /// FoodID property used to hold FoodID of the instance of <see cref="FoodDetails"/>
        /// 
        /// </summary>
        /// <value></value>
        public string FoodID { get; set; }

        /// <summary>
        /// 
        /// FoodName property used to hold FoodName of the instance of <see cref="FoodDetails"/>
        /// 
        /// </summary>
        /// <value></value>
        public string FoodName { get; set; }

        /// <summary>
        /// 
        /// FoodPrice property used to hold FoodPrice of the instance of <see cref="FoodDetails"/>
        /// 
        /// </summary>
        /// <value></value>
        public double FoodPrice { get; set; }

        /// <summary>
        /// 
        /// Available quantoty property used to hold available quantity of the instance of <see cref="FoodDetails"/>
        /// 
        /// </summary>
        /// <value></value>
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// Parametrized FoodDetails used to initialize parameter values to its properties
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="foodPrice"></param>
        /// <param name="available"></param> <summary>
        /// 
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="foodPrice"></param>
        /// <param name="available"></param>
        public FoodDetails(string foodName,double foodPrice,int available)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=available;
        }

        public FoodDetails(string food)
        {
            string[] values=food.Split(",");
            FoodID=values[0];
            s_foodID=int.Parse(values[0].Remove(0,3));
            FoodName=values[1];
            FoodPrice=double.Parse(values[2]);
            AvailableQuantity=int.Parse(values[3]);
        }



    }
}