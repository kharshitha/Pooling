using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Interface;

namespace Services
{
    public class PaymentService:IPaymentService
    {
        public Payment TransferFunds(Wallet senderWallet, Wallet receiverWallet, float amount)
        {
            senderWallet.Balance -= amount;
            receiverWallet.Balance += amount;
            return new Payment() { Amount = amount, SenderWalletId = senderWallet.Id, ReceiverWalletId = receiverWallet.Id };
        }
        public void AddPayment(Payment payment,List<Payment> payments)
        {
            payments.Add(payment);
        }
    }
}
