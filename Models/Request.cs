using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Request
    {
        public Request()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string RideId { get; set; }
        public string OffererId { get; set; }
        public string RequesterId { get; set; }
        public Route Route { get; set; }
        public RequestStatus Status { get; set; }
    }
}
