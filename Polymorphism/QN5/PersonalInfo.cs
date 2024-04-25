using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN5
{
    public enum Gender{Male,Female}
    public abstract class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }  
        
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name,string fatherName,string phone,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            
            Phone=phone;
            Gender=gender;
            
        }

        public abstract void Display();
    }
}