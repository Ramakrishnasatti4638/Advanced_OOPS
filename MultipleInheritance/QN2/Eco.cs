using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class Eco:Car,IBrand
    {
        private static int s_makingID=1000;
        //Property:   MakingID(Auto), EngineNumber, ChasisNumber
        public string MakingID { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }

        public string BrandName { get; set; }
        public string ModelName { get; set; }


        public Eco(FuleType fuleType,int noOfSeats,string color,int tankCapacity,double numberOfKmDriven,string engineNumber,string chasisNumber,string brandName,string modelName):base( fuleType, noOfSeats, color, tankCapacity, numberOfKmDriven)
        {
            s_makingID++;
            MakingID="MID"+s_makingID;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            BrandName=brandName;
            ModelName=modelName;
        }
        //Method: Show Details
        public void ShowDetails()
        {
            CalculateMilage();
            System.Console.WriteLine($"Making ID: {MakingID}\nEngine Number: {EngineNumber}\nChasisNumber: {ChasisNumber}\bBrand Name: {BrandName}\nModel Name: {ModelName}\nFuel Type: {FuleType}\nNo of seats: {NumberOfSeats}\nColor: {Color}\nTank Cpacity: {TankCapacity}\nNumber of KMS drivern: {NumberOfKmDriven}\nMileage: {Milage}");
        }
    }
}