using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class UserDetails:PersonalDetails,IBalance
    {
        private static int s_userID=1000;
        private double _balance;
        // •	UserID (Auto – SF1001)
        // •	WorkStationNumber
        // •	Field: _balance
        // •	Read only property: WalletBalance.
        public string UserID { get; set; }
        public string WorkStationNumber { get; set; }
        public double WalletBalance { get{return _balance;} }

        public UserDetails(string name,string fatherName,Gender gender,string mobile,string mailID,string workStationNumber,double walletBalance):base( name, fatherName, gender, mobile, mailID)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WorkStationNumber=workStationNumber;
            _balance=walletBalance;
        }


        public UserDetails(string user):base(user)
        {
            string[] values=user.Split(",");
            UserID=values[0];
            s_userID=int.Parse(values[0].Remove(0,2));
            
            WorkStationNumber=values[6];
            _balance=double.Parse(values[7]);
        }


        //•	WalletRecharge, DeductAmount	
        public double WalletRecharge()
        {
            System.Console.WriteLine("Enter amount to recharge");
            double amount=double.Parse(Console.ReadLine());
            if(amount>0)
            {
                _balance+=amount;
                return WalletBalance;
            }
            else
            {
                System.Console.WriteLine("Enter amount greater than 0");
                return 0;
            }
        }

        public double DeductAmount(double amount)
        {
            
            if(amount<WalletBalance)
            {
                _balance-=amount;
                return WalletBalance;
            }
            else
            {
                System.Console.WriteLine("Insufficient balance");
                return 0;
            }
        }

        public void AddAmount(double amount)
        {
            _balance+=amount;

        }

    }
}