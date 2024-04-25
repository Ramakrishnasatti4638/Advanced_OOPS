using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class TemporaryEmployee:SalaryInfo
    {
        public enum EmployeeType1{Permanent,Temporary}
        private static int s_employeeID=1000;
        //Properties: EmployeeID, Employee Type, DA=0.15% of basic, HRA= 0.13% of basic, Total Salary
        public string EmployeeID { get; set; }
        public EmployeeType1 EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }

        public TemporaryEmployee(double basicSalary,int month,EmployeeType1 employeeType):base( basicSalary, month)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            EmployeeType=employeeType;
            
        }

        //Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary
        public void TotalSalaryE()
        {
            TotalSalary=BasicSalary+0.15*BasicSalary+0.13*BasicSalary;
        }

        public void ShowSalary()
        {
            TotalSalaryE();
            System.Console.WriteLine("Your salary is : "+TotalSalary);
        }
    }
}