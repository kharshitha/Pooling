using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Route
    {
        public Route()
        {
            Id = Guid.NewGuid().ToString();
        }
                           
        public string Id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
