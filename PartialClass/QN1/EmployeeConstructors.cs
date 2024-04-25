using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public partial  class EmployeeInfo
    {
        
            public EmployeeInfo(string name,Gender gender,DateTime dob,string mobile)
            {
                s_employeeID++;
                EmployeeID="SF"+s_employeeID;
                Name=name;
                Gender=gender;
                DOB=dob;
                Mobile=mobile;
            }
       
    }
}