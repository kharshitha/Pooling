using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Linq;
using Interface;

namespace Services
{
    public class RideServices:IRideService
    {
        public List<Ride> GetRideHistory(List<Ride> rides,string userId)
        {
            List<Ride> userRides=new List<Ride>();
            foreach (var ride in rides)
            {
                foreach (var Id in ride.Vehicle.UserIds)
                {
                    if (Id==userId)
                    {
                        userRides.Add(ride);
                    }
                }
            }
            return userRides;
        }
        public void AddRide(List<Ride> rides, Ride ride)
        {
            rides.Add(ride);
        }
        public void CompleteRide(Ride ride)
        {
            ride.Status = Status.Completed;
        }
    }
}
