﻿using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Models;
using OnlineCourses.ViewModels;
using System;
using System.Collections.Generic;
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

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

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
            db.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}