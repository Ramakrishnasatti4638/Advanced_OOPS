using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public interface IBankInfo
    {
        //Properties: BankName, IFSC, Branch
        public string BankName { get; set; }    
        public string IFSC { get; set; }
        public string Branch { get; set; }

        
    }
}