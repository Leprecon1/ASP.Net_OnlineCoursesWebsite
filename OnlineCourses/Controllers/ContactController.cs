using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using OnlineCourses.Services;

namespace OnlineCourses.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string name, string email, string subject, string message)
        {
            EmailService emailService = new EmailService();
            string finalMessage = $"пользователь {name} {email} обратился со следующем письмом: \n {message}";
            await emailService.SendEmailAsync("ilya.Chercasov@gmail.com", subject, finalMessage);
            return RedirectToAction("Index");
        }

         [HttpPost]
        public async Task<IActionResult> Subcribe(string email)
        {
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(email, "Добро пожаловать в edustage", "Рады приветствовать вас в удивительном мире знаний! " +
                "Мы будем сообщать вам о новых событиях и " +
                "интересных мероприятиях");
            return Redirect("/Events/Index");
        }


        [HttpPost]
        public async Task<IActionResult> SubcribeCourse(string email)
        {
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(email, "Добро пожаловать в edustage", "Рады приветствовать вас в удивительном мире знаний! " +
                "Мы будем сообщать вам о новых курсах и " +
                "интересных мероприятиях");
            return Redirect("/Course/Index");
        }
    }
}