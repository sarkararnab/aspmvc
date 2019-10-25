using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogBook.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Number { get; set; }
        public DateTime IssuedOn { get; set; }
        public User User { get; set; }
        public int OwnedBy { get; set; }
    }
}