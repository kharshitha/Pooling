using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IPaymentReceiptService
    {
        public void AddReceipt(PaymentReceipt paymentReceipt, User user);
    }
}
