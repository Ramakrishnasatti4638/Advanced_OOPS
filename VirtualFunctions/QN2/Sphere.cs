using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class Sphere:Dimesion
    {
        public double Radius { get; set; }

        public Sphere(double radius):base(radius,radius)
        {
            Radius=radius;
        }


        public override double Calculate()
        {
            Area= 4*3.14*Radius*Radius;
            return Area;
        }

        public override void Display()
        {
            base.Display();
        }
    }
}