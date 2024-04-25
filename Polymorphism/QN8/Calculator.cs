using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN8
{
    public class Calculator
    {
        public List<double> Sem1 { get; set; }=new List<double>();
        public List<double> Sem2 { get; set; }=new List<double>();
        public List<double> Sem3 { get; set; }=new List<double>();
        public List<double> Sem4 { get; set; }=new List<double>();

        public Calculator(List<double> sem1,List<double> sem2,List<double> sem3,List<double> sem4)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }

        public void Calculate()
        {
            System.Console.WriteLine("Sem1 Total " +Sem1.Sum());
            System.Console.WriteLine("Sem1 Perce4ntage: "+((Sem1.Sum())/600)*100);
            System.Console.WriteLine("Sem2 Total " +Sem2.Sum());
            System.Console.WriteLine("Sem2 Perce4ntage: "+((Sem2.Sum())/600)*100);
            System.Console.WriteLine("Sem3 Total " +Sem3.Sum());
            System.Console.WriteLine("Sem3 Perce4ntage: "+((Sem3.Sum())/600)*100);
            System.Console.WriteLine("Sem4 Total " +Sem1.Sum());
            System.Console.WriteLine("Sem4 Perce4ntage: "+((Sem4.Sum())/600)*100);
        }

        public static Calculator operator +(Calculator calculator1,Calculator calculator2)
        {
            Calculator calculator=new Calculator(new List<double>(),new List<double>(),new List<double>(),new List<double>());

        }

        
        

    }
}