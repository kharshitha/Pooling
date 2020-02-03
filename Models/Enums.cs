using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public enum Gender
    {
        Female = 0, Male
    }
    public enum Role
    {
        Driver=0,
        Passenger
    }
    public enum Status
    {
        NotYetStarted = 0,
        Running,
        Cancelled,
        Completed
    }
    public enum RequestStatus
    {
        NotApproved=0,
        Conform,
        Rejected
    }
    public enum PaymentStatus
    {
        Successful=0,
        Cancelled
    }
    public enum Mode
    {
        Credit=0,
        Debit
    }
}
