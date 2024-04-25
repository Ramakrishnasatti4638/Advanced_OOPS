using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public interface ICalculate
    {
        //Properties: ProjectMark
        public double ProjectMark { get; set; }
        //Methods: CalculateUG -> Total, Percentage.
        public void CalculateUG();
    }
}