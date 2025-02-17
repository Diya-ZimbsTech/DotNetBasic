using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BindDDLWithDatabase.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BindDDLWithDatabase.Controllers;

public class HomeController : Controller
{
    private readonly CodeFirstDbContext context;

    public HomeController(CodeFirstDbContext context)
    {
        this.context = context;
    }
    private StudentModel BindDDL()
    {
        StudentModel stdmodel = new StudentModel();
        stdmodel.StudentList = new List<SelectListItem>();
        var data = context.Students.ToList();
        stdmodel.StudentList.Add(new SelectListItem
        {
            Text = "Select Name",
            Value = ""
        });
        foreach (var item in data)
        {
            stdmodel.StudentList.Add(new SelectListItem
            {
                Text = item.StudentName,
                Value = item.Id.ToString()
            });
        }
        return stdmodel; // Ensure the method returns a value
    }
    public IActionResult Index()
    {
        var std = BindDDL();

        return View(std);
    }

    [HttpPost]
    public IActionResult Index(StudentModel std)
    {
        var student = context.Students.Where(x => x.Id == std.Id).FirstOrDefault();
        if(student != null)
        {
            ViewBag.SelectedStudent = student.StudentName;
        }
        var myStudent = BindDDL();


        return View(myStudent);
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
