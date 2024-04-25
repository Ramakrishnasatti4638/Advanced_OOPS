using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public enum Gender{Male,Female}
    public partial class StudentInfo
    {
        private static int s_studentID=1000;
        //properties -  StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
        public string StudentID { get;  }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
    }
}