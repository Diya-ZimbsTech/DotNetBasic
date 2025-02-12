using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASPCore.Models;

namespace StronglyTypedViewASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var obj = new List<Employee>
            {
                new Employee() { EmpId = 101, EmpName = "John", Designation = "Software Engineer", Salary = 50000 },
                new Employee() { EmpId = 102, EmpName = "Smith", Designation = "Sr. Software Engineer", Salary = 60000 },
                new Employee() { EmpId = 103, EmpName = "Peter", Designation = "Team Lead", Salary = 70000 },
                new Employee() { EmpId = 104, EmpName = "Sam", Designation = "Project Manager", Salary = 80000 }
            };


            //Employee obj = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "John",
            //    Designation = "Software Engineer",
            //    Salary = 50000
            //};
            return View(obj);
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
