using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public partial class EmployeeInfo
    {
        public void Update(string name,Gender gender,DateTime dob,string mobile)
        {
                Name=name;
                Gender=gender;
                DOB=dob;
                Mobile=mobile;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}\nName: {Name}\nGender: {Gender}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nMobile: {Mobile}");
        }

    }
}