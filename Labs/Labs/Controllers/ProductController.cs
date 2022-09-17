using Labs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labs.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("ShowAll");
        }
        public IActionResult ShowAll()
        {
            ViewData["Heading"] = "All Products";
            var products = new List<Product>();
            products.Add(new Product { ID = 101, Name = "Long", Price = 499 });
            products.Add(new Product { ID = 102, Name = "Sang", Price = 499 });
            products.Add(new Product { ID = 103, Name = "An", Price = 499 });
            return View(products);
        }
    }
}
