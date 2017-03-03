using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegularClassAPI.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int Faculty_Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Subject_Name { get; set; }
        public List<Student> Student { get; set; }
        public int Class_Id { get; set; }

        List<Attendance> Attendance_List { get; set; }
    }
}