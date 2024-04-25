using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;

namespace CafeteriaCardManagement
{
    public partial class Operations
    {
        //ShowMyProfile
        public static void ShowMyProfile()
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine("Name: " + currentLoggedInUser.Name);
            System.Console.WriteLine("Father Name: " + currentLoggedInUser.FatherName);
            System.Console.WriteLine("Mobile Number: " + currentLoggedInUser.Mobile);
            System.Console.WriteLine("Mail ID: " + currentLoggedInUser.MailID);
            System.Console.WriteLine("Gender: " + currentLoggedInUser.Gender);
            System.Console.WriteLine("WorkStationNumber: " + currentLoggedInUser.WorkStationNumber);
            System.Console.WriteLine("Balance: " + currentLoggedInUser.WalletBalance);
        }
        //ShowMyProfile ends

        //FoodOrder
        public static void FoodOrder()
        {
            string option = "yes";
            //create local cartitemlist
            CustomList<CartItem> cartItems = new CustomList<CartItem>();
            //Create order object with current userID,order date now,price 0 ,status initiated
            OrderDetails order = new OrderDetails(currentLoggedInUser.UserID, DateTime.Now, 0, OrderStatus.Initiated);
            do
            {


                System.Console.WriteLine("|Food ID|Food name|Price|Available quantity|");
                foreach (FoodDetails food in foodList)
                {
                    System.Console.WriteLine($"|{food.FoodID}|{food.FoodName}|{food.FoodPrice}|{food.AvailableQuantity}|");
                }



                //Ask user to pick productID
                System.Console.WriteLine("Enter the productID of the product you want: ");
                string productID = Console.ReadLine().ToUpper();
                bool flag = true;
                if (productID != null)
                {
                    // ask Quantity and calculate price

                    foreach (FoodDetails food in foodList)
                    {
                        if (food.FoodID == productID)
                        {
                            flag = false;
                            System.Console.WriteLine("Enter the quantity: ");
                            int quantity = int.Parse(Console.ReadLine());
                            bool flag1 = true;
                            if (quantity > 0 && food.AvailableQuantity > quantity)
                            {
                                //if food and quantity available reduce them in food and create cartitems object with available data
                                food.AvailableQuantity -= quantity;
                                double price = quantity * food.FoodPrice;
                                flag1 = false;
                                CartItem cart = new CartItem(order.OrderID, food.FoodID, price, quantity);
                                //add that object to local cartitem list
                                cartItems.Add(cart);
                                //Ask user whether he wants to pick another product
                                System.Console.WriteLine("Do you want to pick another order(yes/no): ");
                                option = Console.ReadLine();
                                if (option == "no")
                                {
                                    //if no 
                                    //ask user to confirm to purchase wishlist
                                    System.Console.WriteLine("Do you want to purchase the item in wishlist(yes/no)");
                                    string pruchase = Console.ReadLine();

                                    //if no then traverse local cartitem list get the items one by one and reverse the quantity to food items
                                    if (pruchase == "no")
                                    {
                                        foreach (CartItem cartItem in cartItems)
                                        {
                                            foreach (FoodDetails food1 in foodList)
                                            {
                                                if (food1.FoodID == cartItem.FoodID)
                                                {
                                                    food1.AvailableQuantity += cartItem.OrderQuantity;
                                                    break;
                                                }
                                            }


                                        }
                                        break;
                                    }

                                    //if yes calculate total price of food using local cartitemlist and check the balance 
                                    double totalPrice = 0;
                                    foreach (CartItem cartItem in cartItems)
                                    {
                                        totalPrice += cartItem.OrderPrice;
                                    }
                                    if (totalPrice > currentLoggedInUser.WalletBalance)
                                    {
                                        //if not display message 
                                        //ask him he wants to rechgarge or not
                                        System.Console.WriteLine("In sufficient balance to purchase");
                                        System.Console.WriteLine("Do you want to recharge you wallet: ");
                                        string recharge = Console.ReadLine();

                                        //if no then display message and need to return the items to food list
                                        if (recharge == "no")
                                        {
                                            System.Console.WriteLine("Exiting without Order due to insufficient balance");
                                            foreach (CartItem cartItem in cartItems)
                                            {
                                                if (food.FoodID == cartItem.FoodID)
                                                {
                                                    food.AvailableQuantity += cartItem.OrderQuantity;
                                                }

                                            }
                                            break;
                                        }
                                        //if yes ask him to recharge with the orderprice
                                        System.Console.WriteLine("Recharge with " + totalPrice + " amount.");
                                        currentLoggedInUser.WalletRecharge();
                                    }

                                    //if he had enough balance then deduct the amount 
                                    currentLoggedInUser.DeductAmount(totalPrice);
                                    //append local cartitem list to global cartitem list

                                    cartList.AddRange(cartItems);

                                    //modify the total price as orderprice and orderstatsus as ordered
                                    order.TotalPrice = totalPrice;
                                    order.OrderStatus = OrderStatus.Ordered;
                                    //add object to order list 
                                    orderList.Add(order);
                                    //show order message and order id
                                    System.Console.WriteLine("Order placed successfully your orderid is :" + order.OrderID);

                                }

                            }
                            if (flag1)
                            {
                                System.Console.WriteLine("Enter quantity is more than available");
                                System.Console.WriteLine("Current available quantity is: " + food.AvailableQuantity);
                                break;
                            }
                        }
                    }
                }
                if (flag)
                {
                    System.Console.WriteLine("Invalid input");
                    break;
                }



            } while (option == "yes");


        }

        //FoodOrder ends

        //ModifyOrder
        public static void ModifyOrder()
        {

            //show the current user order details
            int count = 0;
            foreach (OrderDetails order in orderList)
            {
                if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    count++;
                }
            }
            if (count != 0)
            {
                int newCount = 0;
                bool isFound = false;
                foreach (OrderDetails order in orderList)
                {
                    if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        newCount++;
                        if (newCount == count)
                        {
                            isFound = true;
                            System.Console.WriteLine("|Item ID|OrderID|FoodID|OrderPrice|OrderQuantity|");
                            foreach (CartItem cartItem in cartList)
                            {
                                if (order.OrderID == cartItem.OrderID)
                                {
                                    System.Console.WriteLine($"|{cartItem.ItemID}|{cartItem.OrderID}|{cartItem.FoodID}|{cartItem.OrderPrice}|{cartItem.OrderQuantity}");

                                }
                            }
                            //ask the user to pick an item
                            System.Console.WriteLine("Enter item if you want to modify");
                            string itemID = Console.ReadLine();
                            //check item id available
                            //CartItem cart=cartList.Find(x=>x.ItemID==itemID);
                            CartItem cart = BinarySearch(cartList, itemID);
                            if (cart != null)
                            {
                                //ask user to enter new quantity
                                System.Console.WriteLine("Enter the quantity to increase or decrease(-1): ");
                                int quantity = int.Parse(Console.ReadLine());
                                if (quantity < 0)
                                {
                                    foreach (FoodDetails food in foodList)
                                    {
                                        if (cart.FoodID == food.FoodID)
                                        {
                                            food.AvailableQuantity -= quantity;
                                            //calculate item price and update in orderprice
                                            double priceToDecrease = Math.Abs(quantity) * food.FoodPrice;
                                            currentLoggedInUser.AddAmount(priceToDecrease);
                                            //calculate total and update in order details entry
                                            order.TotalPrice = order.TotalPrice - priceToDecrease;
                                            cart.OrderQuantity += quantity;
                                            System.Console.WriteLine("Order modified successfully");
                                            break;
                                        }
                                    }
                                }
                                else if (quantity > 0)
                                {
                                    foreach (FoodDetails food in foodList)
                                    {
                                        if (cart.FoodID == food.FoodID)
                                        {
                                            if (quantity < food.AvailableQuantity)
                                            {
                                                food.AvailableQuantity -= quantity;
                                                //calculate item price and update in orderprice
                                                double priceToIncrease = quantity * food.FoodPrice;
                                                currentLoggedInUser.AddAmount(priceToIncrease);
                                                //calculate total and update in order details entry
                                                order.TotalPrice = order.TotalPrice + priceToIncrease;
                                                cart.OrderQuantity += quantity;
                                                System.Console.WriteLine("Order modified successfully");
                                                break;
                                            }
                                            else
                                            {
                                                System.Console.WriteLine("Enter quantity is more than available quantity");
                                            }

                                        }
                                    }
                                }

                            }
                            break;
                        }

                    }
                }
                if (!isFound)
                {
                    System.Console.WriteLine("No orders placed  to modify");
                    return;
                }
            }


        }
        //ModifyOrder ends



        public static void CancelOrder()
        {
            //show current users order details
            int count = 0;
            foreach (OrderDetails order in orderList)
            {
                if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    count++;
                }
            }
            if (count != 0)
            {
                System.Console.WriteLine("|OrderID|UserID|OrderDate|TotalPrice|OrderStatus|");
                foreach (OrderDetails order in orderList)
                {
                    if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        System.Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.TotalPrice}|{order.OrderStatus}");
                    }
                }
                //Ask user to pick orderID
                System.Console.WriteLine("Enter the orderID you want to cancel");
                string orderID = Console.ReadLine().ToUpper();

                //Check it is valid or not 
                if (orderID != null)
                {
                    foreach (OrderDetails order in orderList)
                    {
                        if (order.OrderID.Equals(orderID))
                        {
                            //if valid return totalamount to user balance 
                            currentLoggedInUser.AddAmount(order.TotalPrice);
                            //return product quantity to Fooditems
                            foreach (CartItem cartItem in cartList)
                            {
                                foreach (FoodDetails food1 in foodList)
                                {
                                    if (food1.FoodID == cartItem.FoodID && cartItem.OrderID == orderID)
                                    {
                                        food1.AvailableQuantity += cartItem.OrderQuantity;

                                        break;
                                    }
                                }
                            }
                            //change order status as cancelled
                            order.OrderStatus = OrderStatus.Cancelled;
                            //Disply message
                            System.Console.WriteLine("Order cancelled successfully");

                        }

                    }

                }

            }
            if (count == 0)
            {
                System.Console.WriteLine("No orders placed  to cancel.");
                return;
            }

        }
        //CancelOrder ends
        //OrderHistory
        public static void OrderHistory()
        {
            //OrderDetails order=orderList.Find(x=>x.UserID==currentLoggedInUser.UserID);
            OrderDetails order = BinarySearch(orderList, currentLoggedInUser.UserID);
            if (order != null)
            {
                System.Console.WriteLine("|Order ID|User ID|Order Date|Total Price|Order Status");
                foreach (OrderDetails order1 in orderList)
                {
                    if (order1.UserID == currentLoggedInUser.UserID)
                    {
                        System.Console.WriteLine(line);
                        System.Console.WriteLine($"|{order1.OrderID}|{currentLoggedInUser.UserID}|{order1.OrderDate.ToString("dd/MM/yyyy")}|{order1.TotalPrice}|{order1.OrderStatus}");
                    }
                }
            }
            else
            {
                System.Console.WriteLine("No orders found. Order first");
            }

        }
        //OrderHistory ends

        public static OrderDetails BinarySearch(CustomList<OrderDetails> elements, string searchElement)
        {
            // int i=0;
            // UserDetails first=elements[i];
            int left = 0, right = elements.Count - 1;
            while (left <= right)
            {
                int middle = left + ((right - left) / 2);
                if (elements[middle].UserID.Equals(searchElement))
                {
                    return elements[middle];
                }
                else if (string.Compare(elements[middle].UserID, searchElement) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;

                }
            }
            //Element not found
            return null;
        }

        public static OrderDetails BinarySearch1(CustomList<OrderDetails> elements, string searchElement)
        {
            // int i=0;
            // UserDetails first=elements[i];
            int left = 0, right = elements.Count - 1;
            while (left <= right)
            {
                int middle = left + ((right - left) / 2);
                if (elements[middle].OrderID.Equals(searchElement))
                {
                    return elements[middle];
                }
                else if (string.Compare(elements[middle].OrderID, searchElement) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;

                }
            }
            //Element not found
            return null;
        }
        public static CartItem BinarySearch(CustomList<CartItem> elements, string searchElement)
        {
            // int i=0;
            // UserDetails first=elements[i];
            int left = 0, right = elements.Count - 1;
            while (left <= right)
            {
                int middle = left + ((right - left) / 2);
                if (elements[middle].ItemID.Equals(searchElement))
                {
                    return elements[middle];
                }
                else if (string.Compare(elements[middle].ItemID, searchElement) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;

                }
            }
            //Element not found
            return null;
        }
    }
}