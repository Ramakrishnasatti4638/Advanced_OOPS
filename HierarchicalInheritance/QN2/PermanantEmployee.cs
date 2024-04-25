using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public enum EmployeeType{Permanent,Temporary}
    public class PermanantEmployee:SalaryInfo
    {
        private static int s_employeeID=1000;
        //Properties: EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary
        public string EmployeeID { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }

        public PermanantEmployee(double basicSalary,int month,EmployeeType employeeType):base( basicSalary, month)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            EmployeeType=employeeType;
        }

        //Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary
        public void TotalSalaryE()
        {
            TotalSalary=BasicSalary+0.2*BasicSalary+0.18*BasicSalary-0.1*BasicSalary;
        }

        public void ShowSalary()
        {
            TotalSalaryE();
            System.Console.WriteLine("Your salary is : "+TotalSalary);
        }
    }
}