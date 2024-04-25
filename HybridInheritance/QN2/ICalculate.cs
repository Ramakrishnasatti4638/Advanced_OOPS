using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public interface ICalculate
    {

        //Prpoprty
        public double Balance { get; set; }
        //Methods: Deposit, Withdraw, Balance check
        public void Deposit();
        public void Withdraw();
        public void BalanceCheck();
    }
}