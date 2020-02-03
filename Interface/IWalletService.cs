using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IWalletService
    {
        public Wallet AddBalance(Wallet wallet, float amount);
        public float ViewBalance(Wallet wallet);
        public bool HasSufficientbalance(Wallet wallet, float amount);
    }
}
