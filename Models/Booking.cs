using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Booking
    {
        public Booking()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string RideId { get; set; }
        public string UserId { get; set; }
        public Route Route { get; set; }
    }
}
