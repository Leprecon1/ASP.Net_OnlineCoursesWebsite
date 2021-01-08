using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Models;
using OnlineCourses.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Components
{
    public class LastUpcomingEvents: ViewComponent 
     {
        private readonly AppDbContext db;

        public LastUpcomingEvents(AppDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            int numberOfEvents = 2;
            var lastEvents = new AllEventsViewModel
            {
                AllEvents = db.Events.OrderBy(e => e.Date).Take(numberOfEvents).Where(e => e.Date > DateTime.Now)
            };
            return View(lastEvents);
        }
    }
}
