using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN3
{
    public class EmployeeInfo //FamilyInfo error cannot inherit due to sealed 
    {
        //Properties: EmployeeID, DateOfJoining
        public string EmployeeID { get; set; }
        public DateTime DOJ { get; set; }

        public EmployeeInfo(string name,string fatherName,string mobile,string mail,Gender gender,string motherName,int noOfSiblings,string nativePlace,string employeeID,DateTime doj)//:base( name, fatherName, mobile, mail, gender, motherName, noOfSiblings, nativePlace)
        {
            EmployeeID=employeeID;
            DOJ=doj;
        }
        //Method: override Update and override DisplayInfo

        // public override void Update(string name,string fatherName,string mobile,string mail,Gender gender,string motherName,int noOfSiblings,string nativePlace)
        // {
        //     base.Update(name,fatherName,mobile,mail,gender);
        // }

        // public override void DisplayInfo()
        // {
        //     base.DisplayInfo();

        // }
        
    }
}