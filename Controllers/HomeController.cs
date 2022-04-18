using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyFirstApplication.Models;

namespace MyFirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Sasha =  hour > 12? "Good morgine" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuesResponse response)
        {
            if (ModelState.IsValid)
            {
                
                Repository.AddResponse(response);
                //Сохроняет ответ пользователя.
                return View("Thanks", response); 
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r=>r.WillAttend==true));
        }
    }
}