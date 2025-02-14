using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionASPCore.Models;
using Microsoft.AspNetCore.Http;

namespace SessionASPCore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetString("MyKey", "Diya Patel");
        TempData["SessionID"] = HttpContext.Session.Id;
        return View();
    }
    public IActionResult About()
    {
        if (HttpContext.Session.GetString("MyKey") != null)
        {
            ViewBag.Name = HttpContext.Session.GetString("MyKey").ToString();
        }
        return View();
    } 
    public IActionResult Details()
    {
        if(HttpContext.Session.GetString("MyKey") != null)
        {
            ViewBag.Name = HttpContext.Session.GetString("MyKey").ToString();
        }
        return View();
    }

    public IActionResult Logout()
    {
        if (HttpContext.Session.GetString("MyKey") != null)
        {
            HttpContext.Session.Remove("MyKey");
        }
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
