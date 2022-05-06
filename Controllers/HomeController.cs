using ass_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

namespace ass_1.Controllers
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
            ViewData["str1"] = "This is a string passed using ViewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;
            return View();

        }

        [Route("Home/AddUser")]
        public IActionResult AddUser()
        {
            return View();
        }

        public ActionResult SaveUser(User u)
        {

            StreamWriter sw = new
             StreamWriter("C:/Users/HI/Documents/DOT NET/ass 1/Views/Home/Newtext3.txt", true);
            sw.WriteLine("User details added on: " +
             DateTime.Now.ToString());
            sw.WriteLine("User name: " + u.UserName);
            sw.WriteLine("Password: " + u.Password);
            sw.WriteLine();
            sw.Close();
            //Console.Write(u.UserName + u.Password);
            return Content("User details have been saved");
        }


        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/Home/priya1")]
        public IActionResult HtmlHelpers()
        {
            return View();

        }
        [Route("/Home/priya")]
        public IActionResult MyApplication()
        {
            return View();
        }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult printUser(User u)
        {
            Console.WriteLine(u.UserName, u.Password);
            return Content("the details are printed in the console");
        }
    }
}