using Microsoft.AspNetCore.Mvc;
using Raptors.Models;
using System.Net.Http.Headers;

namespace Raptors.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Models.Raptors player = new Models.Raptors()
            {
                PlayerName = "Sunaina Kharangate",
            ArrivalDate = new DateTime(2023, 6, 12)
            };
            return View(player);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return Content("Edit");
        }

        [HttpGet]
        public IActionResult SimpleBinding()
        {
            Player p = new Player();
            p.PlayerName = "Sneha Sawant";
            p.Position = "Guard";
            return View(p);
        }

        [HttpPost] 
        public IActionResult SimpleBinding(Player raptor)
        {
            if(ModelState.IsValid)
            {
                return Content(raptor.PlayerName + " updated");
            }
            else
            {
                return View(raptor);
            }

            return Content(raptor.PlayerName + " update");
        }
    }
}
