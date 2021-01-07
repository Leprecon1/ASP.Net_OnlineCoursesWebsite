using OnlineCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.ViewModels
{
    public class AllEventsViewModel
    {
        public IEnumerable<Events> AllEvents { get; set; }
    }
}
