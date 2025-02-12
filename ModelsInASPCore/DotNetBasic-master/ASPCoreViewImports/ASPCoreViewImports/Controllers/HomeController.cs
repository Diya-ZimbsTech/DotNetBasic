using ASPCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Students> students = new List<Students>
            {
                new Students { Id = 1 ,Name = "John", Gender= "Male"},
                new Students { Id =2, Name = "smit", Gender = "male"},
                new Students { Id =3, Name = "eva", Gender = "female"}
            };
            return View(students);
        } 
        public IActionResult About()
        {
            List<Students> students = new List<Students>
            {
                new Students { Id = 1 ,Name = "John", Gender= "Male"},
                new Students { Id =2, Name = "smit", Gender = "male"},
                new Students { Id =3, Name = "eva", Gender = "female"}
            };
            return View(students);
        }
        public IActionResult Contact()
        {
            List<Students> students = new List<Students>
            {
                new Students { Id = 1 ,Name = "John", Gender= "Male"},
                new Students { Id =2, Name = "smit", Gender = "male"},
                new Students { Id =3, Name = "eva", Gender = "female"}
            };
            return View(students);
        }
    }
}
