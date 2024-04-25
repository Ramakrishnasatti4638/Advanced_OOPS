using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Class UserDetails used to create instance of <see cref="UserDetails"/>
    /// </summary>
    public class UserDetails : PersonalDetails, IBalance
    {

        //static field
        /// <summary>
        /// Static field s_cardNumber used to auto increment <see cref="UserDetails"/>
        /// </summary>
        public static int s_cardNumber = 1000;
        //     Properties:
        // •	CardNumber(Auto generation- CMRL1001)
        // •	Balance

        /// <summary>
        /// Property CardNumber used to hold the cardnumber value of instance <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public string CardNumber { get; }

        /// <summary>
        /// Property Balance used to hold the balance value of instance <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public int Balance { get; set; }

        /// <summary>
        /// Constructor UserDetails used to assign values to the properties <see cref="UserDetails"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public UserDetails(string name, string phone, int balance) : base(name, phone)
        {
            s_cardNumber++;
            CardNumber = "CMRL" + s_cardNumber;
            Balance = balance;
        }

        /// <summary>
        /// Constructor UserDetails used to assign values to the properties in the file <see cref="UserDetails"/>
        /// </summary>
        /// <param name="user"></param>
        public UserDetails(string user) 
        {
            string[] values = user.Split(",");
            CardNumber = values[0];
            s_cardNumber = int.Parse(values[0].Remove(0, 4));
            Balance = int.Parse(values[3]);
            UserName=values[1];
            PhoneNumber=values[2];
        }

        /// <summary>
        /// Method Wallet recharge is used to racharge the wallete and assign to balance s<see cref="UserDetails"/>
        /// </summary>
        public void WalletRecharge()
        {
            Console.WriteLine("Enter the amount you want to recharge: ");
            int amount = int.Parse(Console.ReadLine());
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Enter amount more than 0");
            }
        }

        /// <summary>
        /// Method DeductBalance used to deduct the amount from the user <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(int amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}