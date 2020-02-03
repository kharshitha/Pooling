using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Interface;

namespace Services
{
    public class PaymentReceiptService:IPaymentReceiptService
    {
        public void AddReceipt(PaymentReceipt paymentReceipt,User user)
        {
            user.PaymentReceipt.Add(paymentReceipt);
        }
    }
}
