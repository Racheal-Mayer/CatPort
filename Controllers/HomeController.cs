using Microsoft.AspNetCore.Mvc;
using System;

namespace PortfolioII.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("Projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet]
        [Route("Contacts")]
        public IActionResult Contacts()
        {
            return View();
        }
        [HttpPost("home")]
        public IActionResult Home(string Name, string Email, string Message)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine($"{Name} | {Email} | {Message}");
            // return Redirect("/");
            ViewBag.Name = Name;
            ViewBag.Email = Email;
            ViewBag.Message =Message;
            return View("Results");
        }

    }
}