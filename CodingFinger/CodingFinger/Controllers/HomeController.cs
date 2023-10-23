using CodingFinger.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodingFinger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string employername, int age = 24)
        {
            ViewData["Message"] = "Hello " + employername;
            ViewData["Age"] = age;
            return View();  
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}