using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public enum FuleType{Petrol,Diesel}
    public class Car
    {
        //Property: FuleType, NumberOfSeats, Color, TankCapacity, NumberOfKmDriven
        public FuleType FuleType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }
        public double  Milage { get; set; }

        public Car(FuleType fuleType,int noOfSeats,string color,int tankCapacity,double numberOfKmDriven)
        {
            FuleType=fuleType;
            NumberOfSeats=noOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
        }

        //Method: CalculateMilage
        public void CalculateMilage()
        {
            
            Milage=(double)NumberOfKmDriven/TankCapacity;
            //System.Console.WriteLine(milage);
        }
    }
}