using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

namespace CafeteriaCardManagement
{
    public partial class Operations
    {
        public static CustomList<FoodDetails> foodList=new CustomList<FoodDetails>();
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();

        public static CustomList<CartItem> cartList=new CustomList<CartItem>();

        static UserDetails currentLoggedInUser;
        

        static string line="-----------------------------------------------------------";


        //Default values 
        public static void DefaultValues()
        {
            FoodDetails food1=new FoodDetails("Coeffee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,20);
            foodList.AddRange(new CustomList<FoodDetails>() {food1,food2,food3,food4,food5,food6,food7});

            UserDetails user=new UserDetails("Ravichandran","Ettaparajan",Gender.Male,"887777575","ravi@gmail.com","WS101",400);
            UserDetails user1=new UserDetails("Baskaran","Sethurajan",Gender.Male,"9577747744","baskaran@gmail.com","WS105",500);
            userList.AddRange(new CustomList<UserDetails>() {user,user1});

            OrderDetails order=new OrderDetails(user.UserID,new DateTime(2022,06,15),70,OrderStatus.Ordered);
            OrderDetails order1=new OrderDetails(user1.UserID,new DateTime(2022,06,15),100,OrderStatus.Ordered);
            orderList.AddRange(new CustomList<OrderDetails>(){order,order1});

            CartItem cartItem1=new CartItem("OID1001","FID101",20,1);
            CartItem cartItem2=new CartItem("OID1001","FID103",10,1);
            CartItem cartItem3=new CartItem("OID1001","FID105",40,1);
            CartItem cartItem4=new CartItem("OID1002","FID103",10,1);
            CartItem cartItem5=new CartItem("OID1002","FID104",50,1);
            CartItem cartItem6=new CartItem("OID1002","FID105",40,1);
            cartList.AddRange(new CustomList<CartItem>(){cartItem1,cartItem2,cartItem3,cartItem4,cartItem5,cartItem6});
        }
        //Default values ends

        //Main menu
        public static void MainMenu()
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine("Welcome to FOOD Court");
            System.Console.WriteLine(line);
            string mainOption="yes";
            do 
            {
                System.Console.WriteLine($"Main Menu\n1. User Registration\n2. User Login\n3. Exit");
                System.Console.Write("Enter your option: ");
                int menuOption;
                bool tempMenuOption=int.TryParse(Console.ReadLine(),out menuOption);
                while(!tempMenuOption)
                {
                    System.Console.WriteLine("Enter option is invalid.\nPlease try again: ");
                    tempMenuOption=int.TryParse(Console.ReadLine(),out menuOption);
                }
                System.Console.WriteLine(line);
                switch(menuOption)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Closing the application");
                        mainOption="no";
                        break;
                    }
                }
            }while(mainOption=="yes");
        }
        //Main Menu ends

        //User Registration
        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your mobile number: ");
            string mobile=Console.ReadLine();
            string pattern=@"^[6-9]\d{9}$";
            while(Regex.IsMatch(mobile,pattern)==false)
            {
                System.Console.WriteLine("Enter number is in wrong format\nPlease Try again: ");
                mobile=Console.ReadLine();
            }
            System.Console.WriteLine("Enter your mailID: ");
            string mailID=Console.ReadLine();
            System.Console.WriteLine("Enter your gender{Male,Female,Transgender}: ");
            Gender gender;
            bool tempGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!tempGender)
            {
                System.Console.WriteLine("Enter value is wrong.\nPlease try again: ");
                tempGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            System.Console.WriteLine("Enter your work station number{WS100}: ");
            string workStationNumber=Console.ReadLine();
            System.Console.WriteLine("Enter your balance: ");
            double balance;
            bool tempBalance=double.TryParse(Console.ReadLine(),out balance);
            while(!tempBalance)
            {
                System.Console.WriteLine("Entered balance is wrong\nPlease try again: ");
                tempBalance=double.TryParse(Console.ReadLine(),out balance);
            }
            if(balance<=0)
            {
                System.Console.WriteLine("Enter balance more than 0 and try again registering.");
            }

            UserDetails user=new UserDetails(name,fatherName,gender,mobile,mailID,workStationNumber,balance);
            userList.Add(user);
            System.Console.WriteLine("User Registered successfully. Your userID is: "+user.UserID);
        }
        //User Registration ends

        //User login
        public static void UserLogin()
        {
            //Ask user id from user
            System.Console.WriteLine("Enter your UserID: ");
            string userID=Console.ReadLine().ToUpper();
            
            //validate the userid in userList
            if(userID!=null)
            {
                bool flag=true;
                // UserDetails user=userList.Find(userList,userID);
                UserDetails user=BinarySearch(userList,userID);
                if(user!=null)
                {
                    flag=false;
                    currentLoggedInUser=user;
                    SubMenu();
                }
                if(flag)
                {
                    System.Console.WriteLine("Invalid user ID");
                    System.Console.WriteLine(line);
                }
            }
            
            
        }
        //User login ends

       public static void SubMenu()
       {
        //if user present in list display submenu
            string subMenuOption="yes";
            do
            {
                System.Console.WriteLine(line);
                System.Console.WriteLine($"Sub Menu\na. Show My profile\nb. Food Order\nc. Modify Order\nd. Cancel Order\ne. Order History\nf. Wallet Recharge\ng. Show wallet Balance\nh. Exit");
                char newOption;
                bool tempNewOption=char.TryParse(Console.ReadLine(),out newOption);
                while(!tempNewOption)
                {
                    System.Console.WriteLine("Enter option is wrong\nPlease try again: ");
                    tempNewOption=char.TryParse(Console.ReadLine(),out newOption);
                }
                switch(newOption)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Your Profile");
                        ShowMyProfile();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Food Order");
                        FoodOrder();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Modify Order");
                        ModifyOrder();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Cancel Order");
                        CancelOrder();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 'f':
                    {
                        System.Console.WriteLine("Wallet Recharge");
                        currentLoggedInUser.WalletRecharge();
                        break;
                    }
                    case 'g':
                    {
                        System.Console.WriteLine("Show wallet balance");
                        System.Console.WriteLine(currentLoggedInUser.WalletBalance);
                        break;
                    }
                    case 'h':
                    {
                        System.Console.WriteLine("Going to main menu");
                        subMenuOption="no";
                        break;
                    }
                }
            } while (subMenuOption=="yes");
       }

        

        public static UserDetails BinarySearch(CustomList<UserDetails> elements,string searchElement)
        {
            // int i=0;
            // UserDetails first=elements[i];
            int left=0,right=elements.Count-1;
            while(left<=right)
            {
                int middle=left+((right-left)/2);
                if(elements[middle].UserID.Equals(searchElement))
                {
                    return elements[middle];
                }
                else if(string.Compare(elements[middle].UserID,searchElement)<0)
                {
                    left=middle+1;
                }
                else
                {
                    right=middle-1;
                    
                }
            }
            //Element not found
            return null;
        }
    }
}