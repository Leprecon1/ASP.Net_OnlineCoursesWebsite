using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public bool Availability { get; set; }
        public string AuthorName { get; set; }
        public int TotalTime { get; set; }
        public string ShortDescription { get; set; }
        public string MainDescription { get; set; }
        public byte[] Image { get; set; }
        public bool MonthCourse { get; set; }       
        public string Category { get; set; }
    }
}
