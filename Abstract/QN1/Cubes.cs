using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class Cubes:Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public override double CalculateArea()
        {
            Area=6*Page*Page;
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume=Page*Page*Page;
            return Volume;
        }
    }
}