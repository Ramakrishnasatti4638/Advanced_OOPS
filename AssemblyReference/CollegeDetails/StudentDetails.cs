using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeDetails
{
    public enum Gender{Select,Male,Female}
    public class StudentDetails
    {
        /*
        a.	StudentName
        b.	FatherName
        c.	DOB
        d.	Gender – Enum (Select, Male, Female, Transgender)
        e.	Physics
        f.	Chemistry
        g.	Maths

        */
        //Field 
        //Static field
        private static int s_studentID=3000;
        //Properties
        public string StudentID { get; } //Read only pproperty
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int PhysicsMarks { get; set; }
        public int ChemistryMarks { get; set; }
        public int MathsMarks { get; set; }

        //Constructor
        public StudentDetails(string studentName,string fatherName,DateTime dob,Gender gender, int physicsMarks,int chemistryMarks,int mathsMarks)
        {
            //Auto Incrementation
            s_studentID++;

            StudentID = "SF" + s_studentID;
            StudentName = studentName;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            PhysicsMarks = physicsMarks;
            ChemistryMarks = chemistryMarks;
            MathsMarks = mathsMarks;
        }

        //Methods
        public double Average()
        {
            return (double)(PhysicsMarks+ChemistryMarks+MathsMarks)/3.00;
        }

        public bool CheckEligibility(double cuttOff)
        {
            if(Average()>=cuttOff)
            {
                return true;
            }
            return false;
        }
    }
}