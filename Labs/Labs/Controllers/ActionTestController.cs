using Microsoft.AspNetCore.Mvc;

namespace Labs.Controllers
{
    public class ActionTestController : Controller
    {
        public string Index()
        {
            return "HelloWorld";
        }
        public IActionResult ActionIndex()
        {
            return View("MyView");
        }
    }
}
