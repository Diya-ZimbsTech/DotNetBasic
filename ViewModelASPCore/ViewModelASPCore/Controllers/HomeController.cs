using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelASPCore.Models;

namespace ViewModelASPCore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Diya", Gender = "Female" , Standard = 10},
            new Student { Id = 1, Name = "Fresil", Gender = "male" , Standard = 11},
            new Student { Id = 1, Name = "Jashvi", Gender = "Female" , Standard = 12},

        };

        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher { Id = 1, Name = "Diya", Qualification= "MSc", Salary = 35000},
            new Teacher { Id = 1, Name = "Fresil", Qualification= "Phd", Salary = 45000},
            new Teacher { Id = 1, Name = "Jashvi", Qualification = "Phd", Salary = 55000},

        };
        SchoolViewModel svm = new SchoolViewModel
        {
            myStudents = students,
            myTeachers = teachers
        };
        return View(svm);
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
