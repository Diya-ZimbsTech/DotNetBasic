using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;

namespace ModelDataUsingViewData.Controllers
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
            var Employee = new List<Employee>
            {
                new Employee { EmpId = 101, EmpName = "John", Designation = "Manager", Salary = 50000 },
                new Employee { EmpId = 102, EmpName = "Smith", Designation = "Developer", Salary = 30000 },
                new Employee { EmpId = 103, EmpName = "Peter", Designation = "Tester", Salary = 20000 },
                new Employee { EmpId = 103, EmpName = "Parkar", Designation = "QA", Salary = 20000 },
                new Employee { EmpId = 103, EmpName = "Lalit", Designation = "developer", Salary = 20000 }
                };

            //ViewData["myEmployee"] = Employee;
            //ViewBag.myEmployee = Employee;
            TempData["myEmployee"] = Employee;

            //Employee emp = new Employee
            //{
            //    EmpId = 101,
            //    EmpName = "John",
            //    Designation = "Manager",
            //    Salary = 50000
            //};

            //ViewData["myEmployee"] = emp;
            //ViewBag.myEmployee = emp;
            //TempData["myEmployee"] = emp;

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
