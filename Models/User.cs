using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    { 
        public User()
        {
            Reviews = new List<Review>();
            RequestIds = new List<string>();
            ConfirmationIds = new List<string>();
            PaymentReceipt = new List<PaymentReceipt>();
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set;  }
        public Gender Type { get; set; }
        public Role Role { get; set; }
        public long AdharNo { get; set; }
        public long MobileNo { get; set; }
        public string DrivingLicenseNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public Wallet Wallet { get; set; }
        public List<Review> Reviews { get; set; }
        public List<string> RequestIds { get; set; }
        public List<string> ConfirmationIds { get; set; }
        public List<PaymentReceipt> PaymentReceipt { get; set; }
    }
}
