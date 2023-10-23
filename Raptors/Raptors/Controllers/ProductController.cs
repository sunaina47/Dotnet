using Microsoft.AspNetCore.Mvc;
using Raptors.Models;

namespace Raptors.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Product product = new Product();

            product.Title  = "Badminton";
            product.Price = "80";

            return View(product);

            
        }
    }
}
