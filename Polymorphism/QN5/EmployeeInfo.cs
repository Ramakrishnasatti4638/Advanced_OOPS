using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN5
{
    public class EmployeeInfo:PersonalInfo
    {
        private static int s_employeeID=2000;

        public string EmployeeID { get; set; }

        public EmployeeInfo(string name,string fatherName,string phone,Gender gender):base( name, fatherName, phone, gender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
        }
        public EmployeeInfo(string employee,string name,string fatherName,string phone,Gender gender):base( name, fatherName, phone, gender)
        {
            
            EmployeeID=employee;
        }

        public override void Display()
        {
            System.Console.WriteLine($"Employee ID: {EmployeeID}\nEmployee Name: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nGender: {Gender}");

        }
    }
}