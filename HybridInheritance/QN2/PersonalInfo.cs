using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public enum Gender{Male,Female}
    public class PersonalInfo
    {
        //Properties: Name, Gender, DOB, phone, mobile
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }

        public PersonalInfo(string name,Gender gender,DateTime dob,string phone)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
        }
    }
}