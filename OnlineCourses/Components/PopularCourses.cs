using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCourses.Models;
using OnlineCourses.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Components
{
    public class PopularCourses : ViewComponent
    {
        private readonly AppDbContext db;

        public PopularCourses(AppDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var PopularCourses = new PopularCoursesModel
            {
                PopularCourses = db.Groups.Include(c => c.Course).Include(a => a.Teacher) /*where MonthCourse == true*/
            };
            return View(PopularCourses);
        }
    }
}
