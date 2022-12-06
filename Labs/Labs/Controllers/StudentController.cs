using Labs.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;

namespace Lab02.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        string TxtFullPath => Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.txt");//Trong truong hop xai txt
        string JsonFullPath => Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.json");

        [HttpPost]
        public IActionResult Index(Student sinhVien, string buttonLuu)
        {
            if (buttonLuu == "Lưu file JSON")
            {
                var jsonString = JsonSerializer.Serialize(sinhVien);
                System.IO.File.WriteAllText(JsonFullPath, jsonString);
            }
            else if(buttonLuu == "Lưu file Text")
            {
                String[] txtString = { sinhVien.Id, sinhVien.FullName, sinhVien.Mark.ToString(), sinhVien.Grade.ToString() };
                System.IO.File.WriteAllLines(TxtFullPath, txtString);
            }
            return View(sinhVien);
        }

        public IActionResult ReadData(string type)
        {
            var studentModel = new Student();
            if (type == "JSON")
            {
                var jsonString = System.IO.File.ReadAllText(JsonFullPath);
                studentModel = JsonSerializer.Deserialize<Student>(jsonString);
            }
            else if(type == "TXT")
            {
                String[] lines = System.IO.File.ReadAllLines(TxtFullPath);
                ViewBag.Id = lines[0];
                ViewBag.FullName = lines[1];
                ViewBag.Mark = Convert.ToDouble(lines[2]);
                ViewBag.Grade = lines[3];
            }
            return View("Index", studentModel);
        }
    }
}