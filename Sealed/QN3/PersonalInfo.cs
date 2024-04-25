using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN3
{
    public enum Gender{Male,Female}
    public class PersonalInfo
    {
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
        public virtual void Update(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nFather Name: {FatherName}\nMobile: {Mobile}\nMail: {Mail}\nGender: {Gender}");
            
        }
    }
}