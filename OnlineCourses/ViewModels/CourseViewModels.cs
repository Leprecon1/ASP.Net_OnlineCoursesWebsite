using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.ViewModels
{
    public class CourseViewModels
    {
        public string Name { get; set; }
        public bool Availability { get; set; }
        public string AuthorName { get; set; }
        public int TotalTime { get; set; }
        public string ShortDescription { get; set; }
        public string MainDescription { get; set; }
        public IFormFile Image { get; set; }
        public bool MonthCourse { get; set; }
        public string Category { get; set; }
        public string TeacherName { get; set; }
        public int Periodicity { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

    }
}
