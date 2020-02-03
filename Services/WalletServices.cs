using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Linq;
using Interface;

namespace Services
{
    public class WalletServices:IWalletService
    {
        public Wallet AddBalance(Wallet wallet,float amount)
        {
            wallet.Balance += amount;
            return wallet;
        }
        public float ViewBalance(Wallet wallet)
        {
            return wallet.Balance;
        }
        public bool HasSufficientbalance(Wallet wallet,float amount)
        {
            bool hasSufficientbalance = false;
            if (wallet.Balance>=amount)
            {
                hasSufficientbalance = true;
                return hasSufficientbalance;
            }
            return hasSufficientbalance;
        }
    }
}
