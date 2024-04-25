using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN7
{
    public class Attendance
    {
        public int TotalWorkingDaysInMonth { get; set; }
        public int NoOfLeavesTaken { get; set; }
        public int NoOfPermissionsTake { get; set; }

        public Attendance(int month,int leaves,int permissions)
        {
            TotalWorkingDaysInMonth=month;
            NoOfLeavesTaken=leaves;
            NoOfPermissionsTake=permissions;
        }

        public double CalculateSalary()
        {
            return (TotalWorkingDaysInMonth-NoOfLeavesTaken+NoOfPermissionsTake)*500;
        }
    }
}