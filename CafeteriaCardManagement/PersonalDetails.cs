using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public enum Gender{Select,Male,Female,Trandgender}
    public class PersonalDetails
    {
        // •	Name
        // •	FatherName
        // •	Gender {Enum - Select, Male, Female, Transgender}
        // •	Mobile
        // •	MailID

        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public string MailID { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            MailID=mailID;
        }

        public PersonalDetails(string user)
        {
            string[] values=user.Split(",");
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[5]);
            Mobile=values[3];
            MailID=values[4];
        }
    }
}