using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.ViewModels
{
    public class TeacherViewModels
    {
        public string TeacherName { get; set; }
        public string About { get; set; }
        public string Specialization { get; set; }
        public IFormFile Photo { get; set; }
    }
}
