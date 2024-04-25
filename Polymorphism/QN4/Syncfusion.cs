using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN4
{
    public class Syncfusion:Freelancer
    {
        private static int s_employeeID=1000;


        public string EmployeeID { get; set; }
        public string WorkLocation { get; set; }

        public Syncfusion(string name,string fatherName,Gender gender,string qualification,string role,int noOfWorkingDays,string workLocation):base( name, fatherName, gender, qualification, role, noOfWorkingDays)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            WorkLocation=workLocation;
        }

        // public override void CalculateSalary()
        // {
        //     base.CalculateSalary();
        //     //SalaryAmount=NoOfWorkingDays*500;
            
        // }

        public override  void DisplayInfo()
        {
            base.CalculateSalary();
            System.Console.WriteLine($"EmployeeID: {EmployeeID}");
            base.DisplayInfo();
            System.Console.WriteLine($"WorkLocation: {WorkLocation}");
        }

    }
}