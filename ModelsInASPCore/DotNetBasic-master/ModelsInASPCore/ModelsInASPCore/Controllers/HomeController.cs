using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
        public List<StudentClass> getAllStudents()
        {
           return _studentRepository.GetAllStudents();
        }
        public StudentClass getById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
        public IActionResult Index()
        { 
        //{
        //    var students = new List<StudentClass>
        //    {
        //        new StudentClass { rollNo = 1, Name = "Rohan" ,Gender = "Male" , Standard = 11},
        //        new StudentClass { rollNo = 2, Name = "LAlit" ,Gender = "Male" , Standard = 10},
        //        new StudentClass { rollNo = 3, Name = "Sujal" ,Gender = "Male" , Standard = 9},
        //        new StudentClass { rollNo = 4, Name = "Diya" ,Gender = "Female" , Standard = 12}
        //    };

        //    ViewData["MyStudent"] = students;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
