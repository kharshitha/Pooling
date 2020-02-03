using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IBookingService
    {
        public void AddBooking(Booking booking, List<Booking> bookings);        
    }
}
