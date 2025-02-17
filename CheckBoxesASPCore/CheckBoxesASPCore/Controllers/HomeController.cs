using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CheckBoxesASPCore.Models;

namespace CheckBoxesASPCore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //public IActionResult Index()
    //{
    //    var model = new ViewModel()
    //    {
    //        AcceptTerms = false,
    //        Text = "I accept the terms and conditions."
    //    };
    //    return View(model);
    //}

    public IActionResult Index()
    {
        var model = new ViewModel()
        {
            CheckBoxes = new List<CheckBoxOption>
            {
                new CheckBoxOption 
                { 
                    IsChecked = false, 
                    Value = "1",
                    Text = "Cricket"
                },
                new CheckBoxOption 
                { 
                    IsChecked = false,
                    Value = "2", 
                    Text = "Football"
                },
                new CheckBoxOption 
                { 
                    IsChecked = true,
                    Value = "3", 
                    Text = "Vollyball" 
                }
            }
        };
        return View(model);
    }
    [HttpPost]
    public IActionResult Index(ViewModel data)
    {
        //var value = data.AcceptTerms;
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
