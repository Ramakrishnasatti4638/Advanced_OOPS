using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class RackInfo:DepartmentDetails
    {
        //Properties: RackNumber, ColumnNumber
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }

        public RackInfo(string departmentName,string degree,int rackNumber,int coulumnNumber):base(departmentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=coulumnNumber;
        }
    }
}