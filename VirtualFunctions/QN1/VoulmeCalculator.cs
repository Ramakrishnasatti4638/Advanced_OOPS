using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class VoulmeCalculator:AreaCalculator
    {
        public double Height { get; set; }

        public VoulmeCalculator(double radius,double height):base(radius)
        {
            Height=height;
        }

        public override double Calculate()
        {
            return base.Calculate()*Height;
        }

        public override void Display()
        {
            System.Console.WriteLine($"Volume: {Calculate()}");
        }
    }
}