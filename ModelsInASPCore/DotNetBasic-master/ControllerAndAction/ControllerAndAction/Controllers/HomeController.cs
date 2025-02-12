using Microsoft.AspNetCore.Mvc;

namespace ControllerAndAction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.data1 = "data1 viewbag";
            ViewData["data2"] = "data2 viewdata";
            TempData["data3"] = "data3 tempdata";

            TempData["data4"] =new List<string>() { "cricket", "football", "basketball" };



            //ViewBag.data1 = "Hello, this is the Index action";
            //ViewBag.data2 = 23;
            //ViewBag.data3 = DateTime.Now.ToShortDateString();

            //ViewData["data7"] = "fresil";
            //ViewBag.data6 = "welcome to my channel fresil";

            //string[] arr = { "apple", "banana", "cherry" };
            //ViewBag.data4 = arr;

            //ViewBag.data5 = new List<string> { "cricket", "football", "basketball" };


            //ViewData["data1"] = "Hello, this is the Index action";
            //ViewData["data2"] = 23;
            //ViewData["data3"] = DateTime.Now.ToLongDateString();

            //string[] arr = { "apple", "banana", "cherry" };
            //ViewData["data4"] = arr;

            //ViewData["data5"] = new List<string> { "cricket", "football", "basketball" };

            TempData.Keep("data3");
            return View();
        }
        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }
        public IActionResult Contact()
        {
            TempData.Keep("data3");
            return View();
        }

        public string Display()
        {
            return "hello fresil";
        }
        public int DisplayId(int id)
        {
            return id;
        }
    }
}
