using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class HSCDetails:StudentInfo
    {
        private static int s_hscMarksSheetNumber=10000;
        //Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
        public string HSCMarksheetNumber { get;  }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }

        
            
        

        public HSCDetails(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int standard,string branch,string academicYear,double physics,double chemistry,double maths):base(  name, fatherName, phone, mail, dob, gender, standard, branch, academicYear)
        {
            s_hscMarksSheetNumber++;
            HSCMarksheetNumber="HSC"+s_hscMarksSheetNumber;
            Physics=physics;
            Chemistry=chemistry;    
            Maths=maths;
            
        }


        public void GetMarks()
        {
            // System.Console.WriteLine("Enter your Physics mark: ");
            // Physics=double.Parse(Console.ReadLine());
            // System.Console.WriteLine("Enter your Chemistry mark: ");
            // Chemistry=double.Parse(Console.ReadLine());
            // System.Console.WriteLine("Enter your Maths mark: ");
            // Maths=double.Parse(Console.ReadLine());
        }

        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Percentage=Total/300*100;
        }

        public void ShowMarkSheet()
        {
            Calculate();
            System.Console.WriteLine($"Physics marks: {Physics}\nChemistry marks: {Chemistry}\nMaths marks: {Maths}\nTotal marks: {Total}\nPercentage: {Percentage}");
        }

    }
}