using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodeFirstASPCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeFirstASPCore.Controllers;

public class HomeController : Controller
{
    private readonly StudentDBContext studentDB;

    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    public HomeController( StudentDBContext StudentDB)
    {
        studentDB = StudentDB;
    }

    public async Task<IActionResult> Index()
    {
        var StdData = await studentDB.Students.ToListAsync();
        return View(StdData);
    }
    public IActionResult Create()
    {
        List<SelectListItem> Gender = new()
        {
            new SelectListItem { Value="Male",Text = "Male" },
            new SelectListItem { Value = "Female", Text = "Female" },
        };
        ViewBag.Gender = Gender;
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Student std)
    {
        if(ModelState.IsValid)
        {
            await studentDB.Students.AddAsync(std);
            await studentDB.SaveChangesAsync();
            TempData["Message"] = $"{std.Name} Added successfully.";
            return RedirectToAction("Index", "Home");
        }
        return View();
    }
    public async Task<IActionResult> Details(int id)
    {
        if(id == null || studentDB.Students == null)
        {
            return NotFound();
        }
        var StdData = await studentDB.Students.FirstOrDefaultAsync(x=>x.Id == id);
        if(StdData == null)
        {
            return NotFound();
        }
        return View(StdData);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        List<SelectListItem> Gender = new()
        {
            new SelectListItem { Value="Male",Text = "Male" },
            new SelectListItem { Value = "Female", Text = "Female" },
        };
        ViewBag.Gender = Gender;
        if (id == null || studentDB.Students == null)
        {
            return NotFound();
        }
        var StdData = await studentDB.Students.FindAsync(id);
        if (StdData == null)
        {
            return NotFound();
        }
        return View(StdData);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id,Student std)
    {
        if(id != std.Id)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            studentDB.Update(std);
            await studentDB.SaveChangesAsync();
            TempData["UMessage"] = $"{std.Name} Updated successfully.";
            return RedirectToAction("Index", "Home");
        }
        return View(std);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || studentDB.Students == null)
        {
            return NotFound();
        }
        var StdData = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id);
        if (StdData == null)
        {
            return NotFound();
        }
        return View(StdData);
    }

    [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        if (id == null || studentDB.Students == null)
        {
            return NotFound();
        }
        var StdData = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id);
        if(StdData != null)
        {
            studentDB.Students.Remove(StdData);
        }
        await studentDB.SaveChangesAsync();
        TempData["DMessage"] = $"{StdData.Name} deleted successfully.";
        return RedirectToAction("Index", "Home");
        
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
