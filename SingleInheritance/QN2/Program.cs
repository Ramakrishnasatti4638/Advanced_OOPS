using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Rama","Murali","944188","satti@gmail.com",new DateTime(2002,03,21),Gender.Male);
        AccountInfo account=new AccountInfo(personal.Name,personal.FatherName,personal.Phone,personal.Mail,personal.DOB,personal.Gender,987456321456,"Tadepalligudem","HDFC0002393",50000);
        account.ShowAccountInfo();
        Console.WriteLine("---------------------------------------");
        account.Deposit();
        Console.WriteLine("-----------------------------------------");
        account.Withdraw();
        Console.WriteLine("----------------------------------------");
        account.ShowBalance();
    }
}