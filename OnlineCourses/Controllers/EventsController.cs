using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Models;
using OnlineCourses.ViewModels;

namespace OnlineCourses.Controllers
{
    public class EventsController : Controller
    {
        private readonly AppDbContext db;

        public EventsController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(string? direction)
        {
            IEnumerable<Events> events;
            if (string.IsNullOrEmpty(direction))
            {
                events = db.Events.Where(e => e.Availability == true);
            }
            else
            {
                events = db.Events.Where(e => e.Availability == true).Where(e => e.Direction == direction);
            }

            var AllEvents1 = new AllEventsViewModel
            {
                AllEvents = events
            };

            return View(AllEvents1);
        }

      [HttpGet]
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult AddEvent(EventViewModel evn)
        {
            Events events =
                new Events 
            {
                    Name = evn.Name,
                    Date = evn.Date,
                    Location = evn.Location,
                    Availability = evn.Availability,
                    ShortDescription = evn.ShortDescription,
                    MainDescription = evn.MainDescription,
                    Direction = evn.Direction
                };

            byte[] imageData = null;
            using (var binaryReader = new BinaryReader(evn.Image.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)evn.Image.Length);
            }
            events.Image = imageData;

            db.Events.Add(events);
            db.SaveChanges();
            return Redirect("/Home/Index");
        }



    }
}