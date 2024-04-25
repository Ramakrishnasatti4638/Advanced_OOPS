using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace QN2
{
    public class AccountInfo:PersonalInfo
    {
        //Properties: AccountNumber, BranchName, IFSCCode, Balance
        public long AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        //Constructor
        public AccountInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,long accountNumber,string branchName,string ifscCode,double balance):base( name, fatherName, phone, mail, dob, gender)

        {
            AccountNumber=accountNumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balance;
        }
        //Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.
        public void ShowAccountInfo()
        {
            Console.WriteLine($"Name: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nMail: {Mail}\nDOB: {DOB}\nGender: {Gender}\nAccount Number: {AccountNumber}\nBranch Name: {BranchName}\nIFSC Code: {IFSCCode}\nBalance: {Balance}");
        }
        
        public void Deposit()
        {
            Console.WriteLine("Enter amount you want to deposit: ");
            double amount=double.Parse(Console.ReadLine());
            if (amount>0)
            {
                Balance+=amount;
                Console.WriteLine("Your Balance after deposit is "+Balance);
            }
            else
            {
                Console.WriteLine("Enter amount more than 0");
            }
            
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter amount you want to withdraw: ");
            double amount=double.Parse(Console.ReadLine());
            if (amount>Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance-=amount;
                Console.WriteLine("Your Balance after withdraw is "+Balance);
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine("Your balance is "+Balance);
        }
    }
}