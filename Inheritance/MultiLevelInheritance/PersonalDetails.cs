using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLeveInheritance
{
    public enum Gender{Male,Female}
    public class PersonalDetails
    {
        private static int s_userID=1000;

        //properties
        public string UserID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string  MobileNumber { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,string mobileNumber)
        {
            s_userID++;
            UserID="UID"+s_userID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
        }

        public PersonalDetails(string userID,string name,string fatherName,Gender gender,string mobileNumber)
        {
            
            UserID=userID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
        }
    }
}