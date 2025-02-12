using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "Hello from the controller";
            ViewData["data2"] = 238;
            string[] arr = { "Apple", "Orange", "Pear" };
            ViewData["data3"] = arr;
            ViewData["data4"] = DateTime.Now.ToLongDateString();
            ViewData["data5"] = new List<string>()
            {
                "Cricket", "Football", "Hockey"
            };
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public string Display()
        {
            return "Hello from the controller";
        }
        public int DisplayId(int id)
        {
            return 4 + id;
        }
    }
}
