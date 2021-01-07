using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.ViewModels
{
    public class EventViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public bool Availability { get; set; }
        public string ShortDescription { get; set; }
        public string MainDescription { get; set; }
        public IFormFile Image { get; set; }
        public string Direction { get; set; }
    }
}
