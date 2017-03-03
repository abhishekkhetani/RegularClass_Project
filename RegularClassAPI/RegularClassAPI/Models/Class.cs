using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegularClassAPI.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal PhoneNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public List<Class> Class_List { get; set; }
    }
}