using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class MarkSheet:TheoryExamMarks,ICalculate
    {
        private static int s_markSheetNumber=10000;
        //Properties: MarksheetNumber, DateOfIssue, Total, Percentage
        public string MarksheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double  Total { get; set; }
        public double Percentage { get; set; }

        public double ProjectMark { get; set; }
        public MarkSheet(string name,string fatherName,string phone,DateTime dob,Gender gender,List<double> Sem1,List<double> Sem2,List<double> Sem3,List<double> Sem4,DateTime dateOfIssue,double projectMark):base( name, fatherName, phone, dob, gender, Sem1, Sem2, Sem3, Sem4)
        {
            s_markSheetNumber++;
            MarksheetNumber="MID"+s_markSheetNumber;
            DateOfIssue=dateOfIssue;
            ProjectMark=projectMark;
            
        }

        //Methods : SHowUGMarkSHeet
        public void CalculateUG()
        {
            Total=Sem1.Sum()+Sem2.Sum()+Sem3.Sum()+Sem4.Sum()+ProjectMark;
            Percentage=(Total/2500.0)*100.0;
        }

        public void SHowUGMarkSHeet()
        {
            CalculateUG();
            System.Console.WriteLine($"Registration Number: {RegistationNumber}\nName: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nSem1 Marks: {string.Join(", ",Sem1)}\nSem2 Marks: {string.Join(", ",Sem2)}\nSem3 Marks: {string.Join(", ",Sem3)}\nSem4 Marks: {string.Join(", ",Sem4)}\nProject Mark: {ProjectMark}\nTotal: {Total}\nPercentaage: {Percentage}");
        }
        
    }
}