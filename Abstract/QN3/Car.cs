using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN3
{
    public enum EngineType{Petrol,Diesel,CNG}
    public enum CarType{HatchBack,Sedan,SUV}
    public abstract class Car
    {
        //Field: No. of wheels=4, No.Of.Doors = 4,
        public int noOfWheels=4;
        public int noOfDoors=4;
        //Properties: Engine type -Petrol,diesel,cng, No.Of.Seats, Price, CarType -hatchback,sedan, suv
        public EngineType EngineType { get; set; }
        public int NoOfSeats { get; set; }  
        public double Price { get; set; }
        public CarType CarType { get; set; }

        //Methods : ShowWheels, show doors
        public  void ShowWheels()
        {
            Console.WriteLine(noOfWheels);
        }

        public void ShowDoors()
        {
            Console.WriteLine(noOfDoors);
        }

        //Abstract methods: get engine type, get no. of seats, get price, get car type, Display  car detail
        public abstract void GetEngineType();
        public abstract void GetNoOfSeats();
        public abstract void GetPrice();
        public abstract void GetCarType();
        public abstract void DisplayCarDetails();
        
    }
}