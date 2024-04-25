using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public interface IBalance
    {
        // Properties: WalletBalance
        public double WalletBalance { get;  }
        // Method: WalletRecharge, DeductAmount
        public  double WalletRecharge();

        public double DeductAmount(double amount);


    }
}