using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public partial class StudentInfo
    {
        public void CalculateTotal()
        {
            double total=Physics+Chemistry+Maths;
            Console.WriteLine("Your total marks are: "+total);
        }

        public void CalculatePercentage()
        {
            double percentage=((Physics+Chemistry+Maths)/300)*(100);
            Console.WriteLine("Your percentage is: "+percentage);
        }
    }
}