using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public sealed class EmployeeInfo
    {
        private static int s_keyInfo=100;
        //Properties: UserID, Password, KeyInfo = 100
        public string UserID { get; set; }
        public string Password { get; set; }
        public int KeyInfo { get; set; }

        public EmployeeInfo(string userID, string password)
        {
            s_keyInfo++;
            UserID=userID;
            Password=password;
            KeyInfo=s_keyInfo;

        }

        //Methods: UpdateInfo, DisplayInfo
        public void UpdateInfo(string userID, string password)
        {
            UserID=userID;
            Password=password;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Your user id is "+UserID);;
            Console.WriteLine("You password : "+Password);
        }

    }
}