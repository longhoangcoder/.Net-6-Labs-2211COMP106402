using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Labs.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
/*
        public string Index()
        {
            return "This is my default action...";
        }*/

        // 
        // GET: /HelloWorld/Welcome/ 

/*        public string Welcome(string name = "Thien Huong", int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }*/


        public IActionResult Index()
        {
            return View();
        }
    }
}
