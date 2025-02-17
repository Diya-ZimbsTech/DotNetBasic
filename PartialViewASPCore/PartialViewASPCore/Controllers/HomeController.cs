using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialViewASPCore.Models;

namespace PartialViewASPCore.Controllers;

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
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Products()
    {
        List<Product> products = new List<Product>()
        {
            new Product(){Id=1,Name="Canon EOS R6 Mark", Description="Description 1", Price=10000.00, Image="~/Images/camera.jpg"},
            new Product(){Id=2, Name="Apple Watch Series 10 ", Description="Description 2", Price=22000.00, Image="~/Images/watch.jpeg"},
            new Product(){Id=3, Name=" HP Victus Laptop", Description="Description 3", Price=63000.00, Image="~/Images/laptop.jpg"},

        };
        return View(products);
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
