using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Hirarichal
{
    public class EmployeeDetails : StudentDetails
    {
        private static int s_employeeID = 1000;
        public string EmployeeID { get; }
        public string Designation { get; set; }

        public EmployeeDetails(string studentID, string userID, string name, string fatherName, Gender gender, string mobileNumber, int standard, string yearOfJoining, string designation) : base(userID,name,fatherName,gender,mobileNumber,standard,yearOfJoining)
        {
            s_employeeID++;
            EmployeeID = "EID" + s_employeeID;
            Designation = designation;
        }
    }
}