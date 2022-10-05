using Microsoft.AspNetCore.Mvc;

namespace Labs.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
