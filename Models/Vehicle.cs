using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Id = Guid.NewGuid().ToString();
            UserIds = new List<string>();
        }
                
        public string Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<string> UserIds { get; set; }

    }
}
