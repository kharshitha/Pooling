using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PaymentReceipt
    {
        public PaymentReceipt()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string PaymentId { get; set; }
        public PaymentStatus Status { get; set; }
        public Mode Mode { get; set; }
        public float Amount { get; set; }
        public float Balance { get; set; }
    }
}
