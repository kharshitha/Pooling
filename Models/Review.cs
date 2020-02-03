using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Review
    {
        public Review()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { set; get; }
        public int Rating { get; set; }
        public Comments Comment { get; set; }
        public enum Comments
        {
            Good=0,
            Average,
            Bad
        }
    }
}
