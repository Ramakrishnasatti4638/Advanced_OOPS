using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Interface IBalance used to create the Interface <see cref="IBalance"/>
    /// </summary>
    public interface IBalance
    {
        /// <summary>
        /// Field Balance used to hold the balance values <see cref="IBalance"/>
        /// </summary>
        /// <value>1-100000000</value>
        public int Balance { get; }

        /// <summary>
        /// Method WalletRecharge is used to recharge the wallet <see cref="IBalance"/>
        /// </summary>
        public void WalletRecharge();

        /// <summary>
        /// Method DeductBalance used to deduct the amount from the wallet <seealso cref="IBalance"/>
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(int amount);
    }
}