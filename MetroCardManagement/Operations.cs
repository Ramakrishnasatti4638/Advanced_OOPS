using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Intrinsics.Arm;

namespace MetroCardManagement
{
    /// <summary>
    /// Partial class Operations used to create an instance of <see cref="Operations"/>
    /// </summary>
    public partial class Operations
    {
        /// <summary>
        /// static list to store the details of user <see cref="Operations"/>
        /// </summary>
        /// <typeparam name="UserDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        /// <summary>
        /// static list to store the details of travel <see cref="Operations"/>
        /// </summary>
        /// <typeparam name="TravelDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<TravelDetails> travelList = new CustomList<TravelDetails>();

        /// <summary>
        /// static list to store the details of ticketfair <see cref="Operations"/>
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <typeparam name="TicketFairDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<TicketFairDetails> ticketFairList = new CustomList<TicketFairDetails>();

        /// <summary>
        /// Field currentLoggedInUser used to store the current user details
        /// </summary>
        static UserDetails currentLoggedInUser;
        static string line = "---------------------------------------------------------";
        /// <summary>
        /// Method DefaultValues used to assign the dfault values to the properties and append to the list <see cref="Operations"/>
        /// </summary>
        public static void DefaultValues()
        {
            //Userdetails
            UserDetails user = new UserDetails("Ravi", "9848812345", 1000);
            UserDetails user1 = new UserDetails("Baskaran", "9948854321", 1000);
            userList.AddRange(new CustomList<UserDetails>() { user, user1 });

            //Traveldetails
            TravelDetails travel1 = new TravelDetails("CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMRL1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMRL1002", "Alandur", "Koyambedu", new DateTime(2023, 11, 10), 25);
            TravelDetails travel4 = new TravelDetails("CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 25);
            travelList.AddRange(new CustomList<TravelDetails>() { travel1, travel2, travel3, travel4 });

            //TicketFair details
            TicketFairDetails ticket1 = new TicketFairDetails("Airport", "Egmore", 55);
            TicketFairDetails ticket2 = new TicketFairDetails("Airport", "Koyambedu", 25);
            TicketFairDetails ticket3 = new TicketFairDetails("Alandur", "Koyambedu", 25);
            TicketFairDetails ticket4 = new TicketFairDetails("Koyambedu", "Egmore", 32);
            TicketFairDetails ticket5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            TicketFairDetails ticket6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            TicketFairDetails ticket7 = new TicketFairDetails("Vadapalani", "Koyambedu", 25);
            TicketFairDetails ticket8 = new TicketFairDetails("Arumbakkam", "Koyambedu", 16);
            ticketFairList.AddRange(new CustomList<TicketFairDetails>() { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8 });
        }

        //Main menu
        /// <summary>
        /// Method MainMenu is used to display the main menu <see cref="Operations"/>
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine(line);
            Console.WriteLine("Wleome to Metro Management");
            Console.WriteLine(line);
            string mainMenuOption = "yes";
            do
            {
                Console.WriteLine(line);
                Console.WriteLine("MainMenu\n1. New User Registration\n2. Login User\n3. Exit");
                Console.WriteLine("Enter your option number from above: ");

                int option;
                bool tempOption = int.TryParse(Console.ReadLine(), out option);
                while (!tempOption)
                {
                    System.Console.WriteLine("Enter value is wrong\nplease try again: ");
                    tempOption = int.TryParse(Console.ReadLine(), out option);
                }
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("User Registration");
                            Console.WriteLine(line);
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine(line);
                            System.Console.WriteLine("User Login");
                            Console.WriteLine(line);
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Closing the application.");
                            mainMenuOption = "no";
                            break;
                        }
                }
            } while (mainMenuOption == "yes");

        }
        //Main menu ends

        //User rgistration

        /// <summary>
        /// Method UserRegistation used to take inputs from the user and add into the list <see cref="Operations"/>
        /// </summary>
        public static void UserRegistration()
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Mobile number: ");
            string check = @"^[6-9]\d{9}$";
            string phone = Console.ReadLine();
            while (Regex.IsMatch(phone, check) == false)
            {
                System.Console.WriteLine("Entered number is wrong\nPlease try again");
                phone = Console.ReadLine();
            }
            Console.WriteLine("Enter your Balance: ");
            int balance;
            bool tempBalance = int.TryParse(Console.ReadLine(), out balance);
            while (!tempBalance)
            {
                System.Console.WriteLine("Entered value is in wrong format\nPlease try again: ");
                tempBalance = int.TryParse(Console.ReadLine(), out balance);
            }
            UserDetails user = new UserDetails(name, phone, balance);
            userList.Add(user);
            System.Console.WriteLine("Your card number is " + user.CardNumber);

        }
        //User Registration ends

        //User Login

        /// <summary>
        /// Method userLogin used to enetr the user into the submenu using his cardnumber <see cref="Operations"/>
        /// </summary>
        public static void UserLogin()
        {
            System.Console.WriteLine("Enter your card number");
            string cardNumber = Console.ReadLine().ToUpper();
            if (cardNumber != null)
            {
                bool isfound = false;
                //UserDetails user=userList.Find(x=>x.CardNumber.Equals(cardNumber));
                UserDetails user = BinarySearch(userList, cardNumber);
                if (user != null)
                {
                    isfound = true;
                    currentLoggedInUser = user;
                    SubMenu();
                }
                if (!isfound)
                {
                    System.Console.WriteLine("Invalid card number");
                }
            }

        }
        //user login ends

        //SubMenu

        /// <summary>
        /// Method Submenu used to display the submenu 
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void SubMenu()
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine("Logged in successfully");
            string subMenuOption = "yes";
            do
            {
                System.Console.WriteLine(line);
                System.Console.WriteLine("Sub Menu\na. Balance check\nb. Recharge\nc. View Travel History\nd. Travel\ne. exit");
                System.Console.WriteLine("Enter your option from above: ");
                char option;
                bool tempOption = char.TryParse(Console.ReadLine(), out option);
                while (!tempOption)
                {
                    System.Console.WriteLine("Enter value is in wrong format\nPlease try again: ");
                    tempOption = char.TryParse(Console.ReadLine(), out option);
                }
                switch (option)
                {
                    case 'a':
                        {
                            System.Console.WriteLine(line);
                            System.Console.WriteLine("Your balance is :" + currentLoggedInUser.Balance);
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine(line);
                            System.Console.WriteLine("Recharge");
                            currentLoggedInUser.WalletRecharge();
                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine(line);
                            System.Console.WriteLine("Travel History");
                            TravelHistory();
                            break;
                        }
                    case 'd':
                        {
                            System.Console.WriteLine(line);
                            System.Console.WriteLine("Travel");
                            Travel();
                            break;
                        }
                    case 'e':
                        {
                            System.Console.WriteLine(line);
                            System.Console.WriteLine("Going back to main menu");
                            subMenuOption = "no";
                            break;
                        }
                }
            } while (subMenuOption == "yes");
        }
        //Submenu ends


        /// <summary>
        /// BinarySearch method is used to search the elements in the list <see cref="Operations"/>
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public static UserDetails BinarySearch(CustomList<UserDetails> list, string cardNumber)
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
    }
}