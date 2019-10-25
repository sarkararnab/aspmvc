using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogBook.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Contact { get; set; }
    }
}