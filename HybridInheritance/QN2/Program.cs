using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Ramakrishna",Gender.Male,new DateTime(2002,03,21),"9441882121");
        IDInfo info=new IDInfo(personal.Name,personal.Gender,personal.DOB,personal.Phone,"98745632145","KPDDS2514K");
        SavingAccount savingAccount = new SavingAccount(info.VoterID,info.Name, info.Gender, info.DOB, info.Phone, info.AadharID, info.PanNumber, 967458963547, AccountType.Savings)
        {
            BankName = "HDFC",
            IFSC = "HDFC0002393",
            Branch = "Vijaywada",
            Balance = 5000
        };
        //Console.WriteLine(savingAccount.VoterID);
        savingAccount.Deposit();
        Console.WriteLine("------------------------------------------------");
        savingAccount.Withdraw();
        Console.WriteLine("------------------------------------------------");
        savingAccount.BalanceCheck();
        Console.WriteLine("---------------------------------------------");

        PersonalInfo personal1=new PersonalInfo("Thanuja",Gender.Female,new DateTime(2000,05,17),"9490172121");
        IDInfo info1=new IDInfo(personal1.Name,personal1.Gender,personal1.DOB,personal1.Phone,"9613545453","KPDsd54355");
        SavingAccount savingAccount1 = new SavingAccount(info1.VoterID,info1.Name, info1.Gender, info1.DOB, info1.Phone, info1.AadharID, info1.PanNumber, 7896541212, AccountType.Balance)
        {
            BankName = "SBI",
            IFSC = "SBIN0002393",
            Branch = "Tadepalligudem",
            Balance = 1000
        };
        //Console.WriteLine(savingAccount1.VoterID);
        savingAccount1.Deposit();
        Console.WriteLine("------------------------------------------------");
        savingAccount1.Withdraw();
        Console.WriteLine("------------------------------------------------");
        savingAccount1.BalanceCheck();

    }
}
