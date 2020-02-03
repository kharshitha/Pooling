using System;
using System.Collections.Generic;
using System.Text;

namespace CarPool
{
    public class Constants
    {
        public static readonly string VehicleNoPattern = @"^[A-Za-z]{2}[0-9]{2}[A-Za-z]{2}[0-9]{4}$";

        public static readonly string AdharNoPattern = @"^\d{12}$";

        public static readonly string MobileNoPattern = @"^[6-9]\d{9}$";
    }
}
