using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class StudentInfo:IDisplayInfo
    {
        //field
        private static int s_studentID=1000;
        //Properties: StudentID, Name, FatherName, Mobile
        public string StudentID { get; set; }
        public string Name  { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }

        public StudentInfo(string name,string fatherName, string phone)
        {
            s_studentID++;
            StudentID="SF"+s_studentID;
            Name=name;
            FatherName=fatherName;
            Mobile=phone;
        }

        public void Display()
        {
            Console.WriteLine("Student ID: "+StudentID);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Father name: "+FatherName);
            Console.WriteLine("Mobile: "+Mobile);
        }

    }
}