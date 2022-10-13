using Microsoft.AspNetCore.Mvc;

namespace Labs.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult UploadSingleFile(IFormFile MyFile)
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MyFiles", MyFile.FileName);
            using (var file = new FileStream(fullPath, FileMode.Create))
            {
                MyFile.CopyTo(file);
            }
            return Redirect("Index");
        }
        public IActionResult UploadMultipleFile(List<IFormFile> MyFiles)
        {
            foreach (var MyFile in MyFiles)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MyFiles", MyFile.FileName);
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    MyFile.CopyTo(file);
                }
            }
            return Redirect("Index");
        }
    }
}
