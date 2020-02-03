using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IVehicleService
    {
        public Vehicle AddUser(Vehicle vehicle, User user);
    }
}
