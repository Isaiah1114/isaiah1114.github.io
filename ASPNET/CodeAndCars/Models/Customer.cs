using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAndCars.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public bool isMember { get; set; }
    }
}