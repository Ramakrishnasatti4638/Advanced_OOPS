using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public enum Gender{Male,Female}
    public class PersonalInfo
    {
        //Properties: Name, FatherName, Mobile, Mail, Gender
        public string Name { get; set; }
        public string FatherName { get; set; }  
        public string Mobile { get; set; }  
        public string Mail { get; set; }    
        public Gender Gender { get; set; }  

        public PersonalInfo(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }

        //Method: UpdateInfo
        public void UpdateInfo(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }
    }
}