using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IRideService
    {
        public List<Ride> GetRideHistory(List<Ride> rides, string userId);
        public void AddRide(List<Ride> rides, Ride ride);
        public void CompleteRide(Ride ride);
    }
}
