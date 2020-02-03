using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Interface;

namespace Services
{
    public class BookingService : IBookingService
    {
        public void AddBooking(Booking booking, List<Booking> bookings)
        {
            bookings.Add(booking);
        }
   
    }

}
