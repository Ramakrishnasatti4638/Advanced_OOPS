using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public enum Gender{Male,Female}
    public enum MaritalStatus{Married,Single}
    public class PersonalInfo:IShowData
    {
        //Properties: Name, Gender,DOB, phone, mobile, Marital details – Married/single
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        //Method: ShowInfo
        public void ShowInfo()
        {
            System.Console.WriteLine($"Name: {Name}\n Gender: {Gender}\nPhone: {Phone}\nMartial Status: {MaritalStatus}");
        }

    }
}