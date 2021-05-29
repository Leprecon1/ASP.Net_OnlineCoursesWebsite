using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Models;
using OnlineCourses.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;

namespace OnlineCourses.Controllers
{
    public class TeacherController:Controller
    {
        private readonly AppDbContext db;

        public TeacherController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public RedirectResult AddTeacher(TeacherViewModels tvm)
        {
            Teacher teacher =
                new Teacher
                {
                    TeacherName = tvm.TeacherName,
                    About = tvm.About,
                    Specialization = tvm.Specialization,
                    
                };

            byte[] PhotoData = null;
            using (var binaryReader = new BinaryReader(tvm.Photo.OpenReadStream()))
            {
                PhotoData = binaryReader.ReadBytes((int)tvm.Photo.Length);
            }
             teacher.Photo = PhotoData;

            db.Teachers.Add(teacher);
            db.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}
