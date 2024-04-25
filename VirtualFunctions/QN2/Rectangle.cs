using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class Rectangle:Dimesion
    {
        //Length, height
        public double Length { get; set; }
        public double Height { get; set; }

        //constructor
        public Rectangle(double length,double height):base(length,height)
        {
            Length=length;
            Height=height;
            
        }

        public override double Calculate()
        {
            return base.Calculate();
        }

        public override void Display()
        {
            base.Display();
        }
    }
}