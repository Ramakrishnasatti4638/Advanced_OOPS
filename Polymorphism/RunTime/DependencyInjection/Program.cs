using System;
using System.Collections.Generic;
namespace DependencyInjection;
public class Program 
{
    public static void Main(string[] args)
    {
        CCAccount ccAccount=new CCAccount();
        ccAccount.AccountNumber=123;
        ccAccount.Name="Ramakrishna";
        ccAccount.Balance=21000;
        

        SBAccount sbAccount=new SBAccount();
        sbAccount.AccountNumber=123;
        sbAccount.Name="plki";
        sbAccount.Balance=1000;

        List<CCAccount> ccList=new List<CCAccount>();
        ccList.Add(ccAccount);
        
        
        List<SBAccount> sbList=new List<SBAccount>();
        sbList.Add(sbAccount);

        List<IAccount> accountList=new List<IAccount>();
        accountList.Add(sbAccount);
        accountList.Add(ccAccount);
    }
}