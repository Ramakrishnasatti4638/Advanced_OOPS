using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public enum AccountType{Savings,Balance}
    public class SavingAccount:IDInfo,ICalculate,IBankInfo
    {
        //Properties: AccountNumber, AccountType->Savings, Balance
        public long AccountNumber { get; set; }
        public AccountType AccountType { get; set; }

        public double Balance { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }

        //Constructor
        public SavingAccount(string voterID,string name,Gender gender,DateTime dob,string phone,string aadharID,string panNumber,long accountNumber,AccountType accountType):base( voterID,name, gender, dob, phone, aadharID, panNumber)
        {
            AccountNumber=accountNumber;
            AccountType=accountType;
        }

        //Methods: Deposit, Withdraw, BalanceCheck
        public void Deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit: ");
            double amount=double.Parse(Console.ReadLine());
            if(amount>0)
            {
                Balance+=amount;
                Console.WriteLine("Your balance after deposit is: "+Balance);
            }
            else
            {
                Console.WriteLine("Enter amount should be greater than 0");
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount you want to Withdraw: ");
            double amount=double.Parse(Console.ReadLine());
            if(amount<Balance)
            {
                Balance-=amount;
                Console.WriteLine("Your balance after withdraw is: "+Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void BalanceCheck()
        {
            Console.WriteLine("Your balance is : "+Balance);
        }
    }
}