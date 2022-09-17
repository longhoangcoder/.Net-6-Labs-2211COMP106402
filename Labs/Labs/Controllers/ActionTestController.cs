using Microsoft.AspNetCore.Mvc;

namespace Labs.Controllers
{
    public class ActionTestController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.LoiChao = hour < 12 ? "Chao Buoi Sang" : "Chao buoi chieu";
            return View();
        }
    }
}
