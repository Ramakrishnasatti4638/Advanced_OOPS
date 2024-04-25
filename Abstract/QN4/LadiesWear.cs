using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN4
{
    public class LadiesWear:Dress
    {
        public override DressType DressType { get; set; }
        public override string DressName { get; set; }
        public override double Price { get; set; }
        public override double TotalPrice { get; set; }

        public override void GetDressInfo()
        {
            Console.WriteLine("Enter dress type: ");
            DressType=Enum.Parse<DressType>(Console.ReadLine(),true);
            Console.WriteLine("Enter dress name: ");
            DressName=Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            Price=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter total price: ");
            TotalPrice=double.Parse(Console.ReadLine());
        }

        public override void DisplayInfo()
        {
            double discount=TotalPrice*(20.00/100.00);
            Console.WriteLine("Your bill is: "+(TotalPrice-discount));
        }

    }
}