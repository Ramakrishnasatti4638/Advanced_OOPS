using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class TheoryExamMarks:PersonalInfo
    {
        //Properties: Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.
        public List<double> Sem1 { get; set; }=new List<double>();
        public List<double> Sem2 { get; set; }=new List<double>();
        public List<double> Sem3 { get; set; }=new List<double>();
        public List<double> Sem4 { get; set; }=new List<double>();

        public TheoryExamMarks(string name,string fatherName,string phone,DateTime dob,Gender gender,List<double> sem1,List<double> sem2,List<double> sem3,List<double> sem4):base( name, fatherName, phone, dob, gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
    }
}