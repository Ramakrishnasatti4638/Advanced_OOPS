using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN3
{
    public class SuzukiCiaz:Car
    {
        public override void GetEngineType()
        {
            Console.WriteLine("Enter car engine type(Petrol,Diesel,CNG): ");
            EngineType=Enum.Parse<EngineType>(Console.ReadLine(),true);
            // bool temp=Enum.TryParse<EngineType>(Console.ReadLine(),true,out EngineType);
            // while(!temp)
            // {
            //     Console.WriteLine("Entered input is wrong please try again: ");
            //     temp=Enum.TryParse<EngineType>(Console.ReadLine(),true,out EngineType);
            // }
        }

        public override void GetNoOfSeats()
        {
            Console.WriteLine("Enter No of seats: ");
            NoOfSeats=int.Parse(Console.ReadLine());
        }

        public override void GetPrice()
        {
            Console.WriteLine("Enter Car Price: ");
            Price=double.Parse(Console.ReadLine());
        }

        public override void GetCarType()
        {
            Console.WriteLine("Enter car type(Hatchback,Sedan,SUV): ");
            CarType=Enum.Parse<CarType>(Console.ReadLine(),true);
            // bool temp=Enum.TryParse<CarType>(Console.ReadLine(),true,out CarType);
            // while(!temp)
            // {
            //     Console.WriteLine("Entered input is wrong please try again: ");
            //     temp=Enum.TryParse<CarType>(Console.ReadLine(),true,out CarType);
            // }
        }

        public override void DisplayCarDetails()
        {
            Console.WriteLine("Car engine type: "+EngineType);
            Console.WriteLine("Car no of seats: "+NoOfSeats);
            Console.WriteLine("Car price: "+Price);
            Console.WriteLine("Car Type: "+CarType);
            Console.Write("Car no of wheels: ");
            ShowWheels();
            Console.Write("Car no of doors: ");
            ShowDoors();
        }
    }
}