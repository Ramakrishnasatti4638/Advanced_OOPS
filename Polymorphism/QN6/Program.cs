using System;
namespace QN6;
class Program 
{
    public static void Main(string[] args)
    {
        Bank bank;
        SBI sbi=new SBI();
        bank=sbi;
        System.Console.WriteLine(bank.GetIntrestInfo());
        ICICI icici=new ICICI();
        bank=icici;
        System.Console.WriteLine(bank.GetIntrestInfo());
        HDFC hdfc=new HDFC();
        bank=hdfc;
        System.Console.WriteLine(bank.GetIntrestInfo());
        IDBI idbi=new IDBI();
        bank=idbi;
        System.Console.WriteLine(bank.GetIntrestInfo());

    }
    
}