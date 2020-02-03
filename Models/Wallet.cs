using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Wallet
    {
        public Wallet()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public float Balance { get; set; }
    }
}
