using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public enum Subject{Maths,Physics,Chemistry}
    public class Teacher:PersonalInfo
    {
        private static int s_teacherID=100;
        //Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining
        public string TeacherID { get; set; }
        public string Department { get; set; }
        public Subject SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public Teacher(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string department,Subject subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base( name, fatherName, dob, phone, gender, mail)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }


        //Methods:  ShowDetails
        public void ShowDetails()
        {
            Console.WriteLine($"Teacher ID: {TeacherID}\nName: {Name}\nFather Name: {FatherName}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nPhone: {Phone}\nGender: {Gender}\nMail: {Mail}\nDepartment: {Department}\nSubject Teaching: {SubjectTeaching}\nQualification: {Qualification}\nYOE: {YearOfExperience}\nDOJ: {DateOfJoining.ToString("dd/MM/yyyy")}");
        }

    }
}