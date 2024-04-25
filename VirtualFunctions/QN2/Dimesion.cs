using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class Dimesion
    {
        //Property: value1, value 2, Area
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }

        //Constructor
        public Dimesion(double value1,double value2)
        {
            Value1=value1;
            Value2=value2;
          
        }

        //Virtual methods
        public virtual double Calculate()
        {
            Area=Value1*Value2;
            return Area;
        }

        public virtual void Display()
        {
            System.Console.WriteLine("Area: "+Area);
        }
    }
}