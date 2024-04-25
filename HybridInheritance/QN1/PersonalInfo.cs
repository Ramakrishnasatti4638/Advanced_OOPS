using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public enum Gender{Male,Female}
    public class PersonalInfo
    {
        private static int s_registrationNumner=1000;
        //Properties: RegistationNumber, Name, FatherName, Phone, DOB, Gender
        public string RegistationNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name,string fatherName,string phone,DateTime dob,Gender gender)
        {
            s_registrationNumner++;
            RegistationNumber="RID"+s_registrationNumner;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
        }

    }
}