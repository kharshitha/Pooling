using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Ride
    {
        public Ride()
        {
            Id = Guid.NewGuid().ToString();
            StopOvers = new List<StopOver>();
        }
        public string Id { get; set; }
        public Vehicle Vehicle{ get; set; }
        public Route Route { get; set; }
        public List<StopOver> StopOvers { get; set; }
        public float Cost { get; set; }
        public bool IsVacant { get; set; }
        public Review Review { get; set; }
        public Status Status { get; set; }
    }
}
