using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IPaymentService
    {
        public Payment TransferFunds(Wallet senderWallet, Wallet receiverWallet, float amount);
        public void AddPayment(Payment payment, List<Payment> payments);
    }
}
