using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Payment
    {
        public Payment()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string SenderWalletId { get; set; }
        public string ReceiverWalletId { get; set; }
        public float Amount { get; set; }
    }
}
