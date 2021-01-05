using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Models;
using OnlineCourses.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Components
{
    public class TopTeachers : ViewComponent
    {
        private readonly AppDbContext db;

        public TopTeachers(AppDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var TopTeachers = new TopTeachersModel { TopTeachers = db.Teachers.Where(x => x.TopTeacher == true) };
            return View(TopTeachers);
        }
    }
}
