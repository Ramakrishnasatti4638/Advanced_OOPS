using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class PrincipalInfo:PersonalInfo
    {

        //Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining
        private static int s_pricipalID=10;
        //Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining
        public string PrincipalID { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public PrincipalInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string qualification,int yearOfExperience,DateTime doj):base( name, fatherName, dob, phone, gender, mail)
        {
            s_pricipalID++;
            PrincipalID="PID"+s_pricipalID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=doj;
        }

        //Methods: ShowDetails
        public void ShowDetails()
        {
            Console.WriteLine($"Teacher ID: {PrincipalID}\nName: {Name}\nFather Name: {FatherName}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nPhone: {Phone}\nGender: {Gender}\nMail: {Mail}\nQualification: {Qualification}\nYOE: {YearOfExperience}\nDOJ: {DateOfJoining.ToString("dd/MM/yyyy")}");
        }
    }
}