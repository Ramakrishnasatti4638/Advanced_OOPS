using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN4
{
    public class Freelancer:PersonalDetails
    {
        //Property: Role, SalaryAmount, NoOfWorkingDays
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }


        public Freelancer(string name,string fatherName,Gender gender,string qualification,string role,int noOfWorkingDays):base( name, fatherName, gender, qualification)
        {
            Role=role;
            
            NoOfWorkingDays=noOfWorkingDays;
        }
        //Method : Virtual CalculateSalary method that calculate salary by NoOfWorkingDays*500 
        public virtual void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
            
        }
        //and virtual display method that display employees details
        public virtual void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {Name}\nFather Name: {FatherName}\nGender: {Gender}\nQualification: {Qualification}\nRole: {Role}\nNo of working days: {NoOfWorkingDays}\nSalary: {SalaryAmount}");
        }
    }
}