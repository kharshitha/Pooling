using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Pool
    {
        public Pool()
        {
            Users = new List<User>();
            Bookings = new List<Booking>();
            Rides = new List<Ride>();
            Payments = new List<Payment>();
            Requests = new List<Request>();
        }
        public List<User> Users { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Ride> Rides { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Request> Requests { get; set; }
    }
}
