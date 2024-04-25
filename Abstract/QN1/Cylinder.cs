using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class Cylinder:Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public override double CalculateArea()
        {
            Area=(2*Math.PI*Radius*(Radius+Height));
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume=Math.PI*Radius*Radius*Height;
            return Volume;
        }
    }
}