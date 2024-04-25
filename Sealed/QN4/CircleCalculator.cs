using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN4
{
    public class CircleCalculator:Calculator
    {
        protected double Radius{get; set;}
        public CircleCalculator(double radius)
        {
            Radius=radius;
        }
        //Methods: sealed override void area - 3.14 * r 2
        public sealed override double Area()
        {
            return 3.14*Radius*Radius;
        }

        public sealed override double Volume()
        {
            System.Console.WriteLine("No volume for circle");
            return 0;
        }

    }
}