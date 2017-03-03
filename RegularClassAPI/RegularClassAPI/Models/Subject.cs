using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegularClassAPI.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class_Id { get; set; }

        List<Subject> Subject_List { get; set; }
    }
}