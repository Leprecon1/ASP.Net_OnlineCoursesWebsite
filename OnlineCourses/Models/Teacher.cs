using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string About { get; set;}
        public string Specialization { get; set; }
        public byte[] Photo { get; set; }
        public bool TopTeacher { get; set; }
    }
}
