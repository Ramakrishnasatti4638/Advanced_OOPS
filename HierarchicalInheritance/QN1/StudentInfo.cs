using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public enum Department{CSE,ECE,EEE}
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentID=1000;
        //Properties: StudentID, Degree, Department, semester
        public string StudentID { get; set; }
        public string Degree { get; set; }  
        public Department Department { get; set; }
        public int Semester { get; set; }

        public StudentInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string degree,Department department,int semester):base( name, fatherName, dob, phone, gender, mail)
        {
            s_studentID++;
            StudentID="SF"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        //Methods: ShowDetails
        public void ShowDetails()
        {
            Console.WriteLine($"Teacher ID: {StudentID}\nName: {Name}\nFather Name: {FatherName}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nPhone: {Phone}\nGender: {Gender}\nMail: {Mail}\nDepartment: {Department}\nDegree: {Degree}\nDepartment: {Department}\nSemester: {Semester}");
        }
    }
}