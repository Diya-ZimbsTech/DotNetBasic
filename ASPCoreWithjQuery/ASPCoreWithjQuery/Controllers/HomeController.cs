using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPCoreWithjQuery.Models;

namespace ASPCoreWithjQuery.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    [HttpPost]
    public int Sub(int num1, int num2)
    {
        return num1 - num2;
    }

    [HttpPost]
    public Calculation calculate(int num1, int num2)
    {
        Calculation mod = new Calculation();
        mod.Add = num1 + num2;
        mod.Substract = num1 - num2;
        mod.Multiply = num1 * num2;
        mod.Division = (decimal) num1 / num2;
        return mod;
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
