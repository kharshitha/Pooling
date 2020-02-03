using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Interface;

namespace Services
{
    public class VehicleService:IVehicleService
    {
        public Vehicle AddUser(Vehicle vehicle,User user)
        {
            vehicle.UserIds.Add(user.Id);
            return vehicle;
        }
    }
}
