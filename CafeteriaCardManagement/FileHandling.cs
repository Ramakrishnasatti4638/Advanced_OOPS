using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CafeteriaCardManagement
{
    public class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("CafeteriaCardManagement"))
            {
                System.Console.WriteLine("Creating folder...");
                Directory.CreateDirectory("CafeteriaCardManagement");
            }
            
            //file for CartItems
            if(!File.Exists("CafeteriaCardManagement/CartItem.csv"))
            {
                System.Console.WriteLine("Creating File..");
                File.Create("CafeteriaCardManagement/CartItem.csv").Close();
            }

            //File for FoodDetails
            if(!File.Exists("CafeteriaCardManagement/FoodDeatils.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("CafeteriaCardManagement/FoodDeatils.csv").Close();
            }

            //File for OrderDetails
            if(!File.Exists("CafeteriaCardManagement/OrderDeatils.csv"))
            {
                System.Console.WriteLine("Craeting file..");
                File.Create("CafeteriaCardManagement/OrderDeatils.csv").Close();
            }

            //File for Personal Details
            // if(!File.Exists("CafeteriaCardManagement/PersonalDeatils.csv"))
            // {
            //     System.Console.WriteLine("Creating file");
            //     File.Create("CafeteriaCardManagement/PersonalDeatils.csv").Close();
            // }

            //File for UserDetails
            if(!File.Exists("CafeteriaCardManagement/UserDeatils.csv"))
            {
                System.Console.WriteLine("Creating file..");
                File.Create("CafeteriaCardManagement/UserDeatils.csv").Close();
            }
        }

        public static void WriteToCSV()
        {
            //cart items
            string[] cartitems=new string[Operations.cartList.Count];
            for(int i=0;i<Operations.cartList.Count;i++)
            {
                cartitems[i]=Operations.cartList[i].ItemID+","+Operations.cartList[i].OrderID+","+Operations.cartList[i].FoodID+","+Operations.cartList[i].OrderPrice+","+Operations.cartList[i].OrderQuantity;
            }
            File.WriteAllLines("CafeteriaCardManagement/CartItem.csv",cartitems);

            //FoodDetails
            string[] foods=new string[Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                foods[i]=Operations.foodList[i].FoodID+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].FoodPrice+","+Operations.foodList[i].AvailableQuantity;
            }
            File.WriteAllLines("CafeteriaCardManagement/FoodDeatils.csv",foods);

            //OrderDetails
            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].UserID+","+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("CafeteriaCardManagement/OrderDeatils.csv",orders);

            //UserDetails
            string[] users=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                users[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].FatherName+","+Operations.userList[i].Mobile+","+Operations.userList[i].MailID+","+Operations.userList[i].Gender+","+Operations.userList[i].WorkStationNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("CafeteriaCardManagement/UserDeatils.csv",users);
        }

        public static void ReadFromCSV()
        {
            //cartitems
            string[] items=File.ReadAllLines("CafeteriaCardManagement/CartItem.csv");
            foreach(string item in items)
            {
                CartItem cartItem=new CartItem(item);
                Operations.cartList.Add(cartItem);
            }

            //FoodDetails
            string[] foods=File.ReadAllLines("CafeteriaCardManagement/FoodDeatils.csv");
            foreach(string food in foods)
            {
                FoodDetails food1=new FoodDetails(food);
                Operations.foodList.Add(food1);
            }

            //OrderDetails
            string[] orders=File.ReadAllLines("CafeteriaCardManagement/OrderDeatils.csv");
            foreach(string order in orders)
            {
                OrderDetails order1=new OrderDetails(order);
                Operations.orderList.Add(order1);
            }

            //UserDetails
            string[] users=File.ReadAllLines("CafeteriaCardManagement/UserDeatils.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operations.userList.Add(user1);
            }
        }
    }
}