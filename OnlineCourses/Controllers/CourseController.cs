using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CodeRefactorings;
using Microsoft.EntityFrameworkCore;
using OnlineCourses.Models;
using OnlineCourses.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Controllers
{
    public class CourseController: Controller
    {
        private readonly AppDbContext db;
        public CourseController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(string? category)
        {
            IEnumerable<Group> groups;
            if (!string.IsNullOrEmpty(category))
            {
                groups = db.Groups.Include(c => c.Course).Include(t => t.Teacher).Where(g => g.Course.Availability == true).Where(g => g.Course
              .Category == category).OrderBy(g => g.Course.Name);
          
            }
            else
            {
                List<Group> groups1 = db.Groups.Include(c => c.Course).Include(t => t.Teacher).Where(g => g.Course.Availability == true)
                 .OrderBy(g => g.Course.Name).ToList();

                groups = db.Groups.Include(c => c.Course).Include(t => t.Teacher).Where(g => g.Course.Availability == true)
                .OrderBy(g => g.Course.Name);
            }

            var AllGroupsView = new AllGroupsViewModel
            {
                AllGroups = groups
            };

            return View(AllGroupsView);
        }

        [HttpPost]
        public IActionResult Search(string? courseName, int minPrice = 0, int maxPrice = 10000, int minHours = 0, int maxHours = 10000, 
            bool isDate = false)
        {
            IEnumerable<Group> groups = null;
            if (!string.IsNullOrEmpty(courseName))
            {
                groups = db.Groups.Include(c => c.Course).Include(t => t.Teacher).Where(g => g.Course.Availability == true).Where(g => g.Course
              .Name.Contains(courseName)).Where(g => g.Price >= minPrice && g.Price <= maxPrice).
              Where(g => g.Course.TotalTime >= minHours && g.Course.TotalTime <= maxPrice).OrderBy(g => g.Course.Name);
            }
            if (string.IsNullOrEmpty(courseName))
            {
                groups = db.Groups.Include(c => c.Course).Include(t => t.Teacher).Where(g => g.Course.Availability == true)
                    .Where(g => g.Price >= minPrice && g.Price <= maxPrice).
                Where(g => g.Course.TotalTime >= minHours && g.Course.TotalTime <= maxHours).OrderBy(g => g.Course.Name);
            }
            if (isDate == true)
            {
                groups = groups.OrderBy(g => g.Date);
            }

            var AllGroupsView = new AllGroupsViewModel
            {
                AllGroups = groups
            };

            return View(AllGroupsView);
        }

        public IActionResult CourseDetails(int? id, string? courseName)
        {
            Group group = new Group();
            if (!string.IsNullOrEmpty(courseName))
            {
                 group = db.Groups.Include(c => c.Course).Include(a => a.Teacher).Where(g => g.Course.Name == courseName).First();
            }
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                group = db.Groups.Include(c => c.Course).Include(a => a.Teacher).Where(g => g.Course.CourseId == id).First();
            }

            return View(group);
        }

     

        public IActionResult CoursePayment(int? id)
        {
            Group group = new Group();  
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                group = db.Groups.Include(c => c.Course).Include(a => a.Teacher).Where(g => g.Course.CourseId == id).First();
            }

            return View(group);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [Authorize(Roles = "admin")]

        [HttpPost]
        public RedirectResult AddCourse(CourseViewModels crs)
        {
            Course course =
                new Course
                {
                    Name = crs.Name,
                    Availability = crs.Availability,
                    AuthorName = crs.AuthorName,
                    TotalTime = crs.TotalTime,
                    ShortDescription = crs.ShortDescription,
                    MainDescription = crs.MainDescription,
                    MonthCourse = crs.MonthCourse,
                    Category = crs.Category
                };

            byte[] imageData = null;
            using (var binaryReader = new BinaryReader(crs.Image.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)crs.Image.Length);
            }
            course.Image = imageData;

            db.Courses.Add(course);

            Teacher teacher = db.Teachers.Where(t => t.TeacherName == crs.TeacherName).First();
            Group group = new Group { 
                Course = course,
                Teacher = teacher,
                Date = crs.Date,
                Periodicity = crs.Periodicity,
                Price = crs.Price
            };
            db.Groups.Add(group);

            db.SaveChanges();
            return Redirect("/Home/Index");
        }

      
    }
}
