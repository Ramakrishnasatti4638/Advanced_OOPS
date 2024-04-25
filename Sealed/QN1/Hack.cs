using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class Hack   //EmployeeInfo  error
    {
        //Properties: StoreUserID, StorePassword
        public string StoreUserID { get; set; }
        public string StorePassword { get; set; }

        public Hack(string storeIserID,string storePassword)
        {
            StoreUserID=storeIserID;
            StorePassword=storePassword;
        }

        //Method: ShowKeyInfo, GetUserInfo, ShowUserInfo
        // public void ShowKeyInfo()
        // {
        //     System.Console.WriteLine(KeyInfo);
        // }

        public void GetUserInfo()
        {

        }

        // public void ShowUserInfo()
        // {
        //     System.Console.WriteLine($"{Name}\n{FatherName}\n{Mobile}\n{Mail}\n{Gender  }");
        // }
    }
}