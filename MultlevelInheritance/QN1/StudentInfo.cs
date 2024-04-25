using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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


        

        public void GetStudentInfo()
        {
            // Console.WriteLine("Enter your name: ");
            // Name=Console.ReadLine();
            // System.Console.WriteLine("Enter your Father name: ");
            // FatherName=Console.ReadLine();
            // System.Console.WriteLine("Enter your number: ");
            // Phone=Console.ReadLine();
            // System.Console.WriteLine("Enter your mailID: ");
            // Mail=Console.ReadLine();
            // System.Console.WriteLine("Enter Date of birth: ");
            // DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            
            // System.Console.WriteLine("Enter your gender: ");
            // Gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            // System.Console.WriteLine("Enter your standard: ");
            // Standard=int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Enter your branch: ");
            // Branch=Console.ReadLine();
            // System.Console.WriteLine("Enter your joining year: ");
            // AcadamicYear=Console.ReadLine();
            //StudentInfo student=new StudentInfo(Name,FatherName,Phone,Mail,DOB,Gender,Standard,Branch,AcadamicYear);
            
                
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Regiistration Number: {RegisterNumber}\nName: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nMailID: {Mail}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nGender: {Gender}\nStandard: {Standard}\nBranch: {Branch}\nAcademicYear: {AcadamicYear}");
        }
    }
}