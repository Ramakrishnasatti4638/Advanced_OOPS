using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{

    public class StudentInfo:PersonalInfo
    {
        private static int s_registrationNumber=1000;
        //Properties
        //RegisterNumber, Standard, Branch, AcadamicYear
        public string RegisterNumber { get;}
        public int Standard { get; set; }
        public string Branch { get; set; }
        public string AcadamicYear { get; set; }


        public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int standard,string branch,string academicYear):base( name, fatherName, phone, mail, dob, gender)
        {
            s_registrationNumber++;
            RegisterNumber="RID"+s_registrationNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=academicYear;
        }
        public void showStudentInfo()
        {
            Console.WriteLine($"Regiistration Number: {RegisterNumber}\nName: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nMailID: {Mail}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nGender: {Gender}\nStandard: {Standard}\nBranch: {Branch}\nAcademicYear: {AcadamicYear}");
        }
        
    }
}