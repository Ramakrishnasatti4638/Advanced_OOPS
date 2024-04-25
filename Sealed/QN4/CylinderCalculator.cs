using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN4
{
    public class CylinderCalculator:Calculator
    {
        private CircleCalculator circleCalculator;
        public CylinderCalculator(double radius)
        {
            circleCalculator=new CircleCalculator(radius);
        }
        //Method: override area ,Volume that used circle area for 3.14 * r 2
        public override double Area()
        {
            return 2*circleCalculator.Area();
        }

        public override double Volume()
        {
            return 0;
        }
    }
}