using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hirarichal
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerID = 2000;
        public string CustomerID { get; }
        public int Balance { get; set; }

        public CustomerDetails(string userID,string name,string fatherName,Gender gender,string mobileNumber,int balance):base(userID,name,fatherName,gender,mobileNumber)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            Balance = balance;
        }
    }
}