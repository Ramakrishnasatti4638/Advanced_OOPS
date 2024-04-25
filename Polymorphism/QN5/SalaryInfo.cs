using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace QN5
{
    public class SalaryInfo:EmployeeInfo
    {
        public int NoOfDaysWorked { get; set; }

        public SalaryInfo(string employee,string name,string fatherName,string phone,Gender gender,int noOfDaysWorked):base( employee,name, fatherName, phone, gender)
        {
            NoOfDaysWorked=noOfDaysWorked;
        }

        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Salary: "+NoOfDaysWorked*500);
        }
    }
}