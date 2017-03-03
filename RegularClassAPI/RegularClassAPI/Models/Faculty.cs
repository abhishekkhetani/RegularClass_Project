using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegularClassAPI.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public decimal Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
        public int Class_Id { get; set; }

        public List<Faculty> Faculty_List { get; set; }
    }
}