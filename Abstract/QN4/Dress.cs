using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN4
{
    public enum DressType{Ladieswear,Menswear,Childrenwear}
    public abstract class Dress
    {
        //Abstract Properties: dress type->Ladieswear, menswear, childrenswear, dress name, price, total price
        public abstract DressType DressType { get; set; }
        public abstract string DressName { get; set; }
        public abstract double Price { get; set; }
        public abstract double TotalPrice { get; set; }

        //Abstract Methods: getdressinfo, Display Info
        public abstract void GetDressInfo();
        public abstract void DisplayInfo();
    }
}