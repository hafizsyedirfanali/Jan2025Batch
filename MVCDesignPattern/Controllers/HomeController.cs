using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;

namespace MVCDesignPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()//function/method called as action
        {
            return View();//default view is index view
        }

        public IActionResult Privacy()
        {
            return View();//default view is privacy view
        }
        public IActionResult Irfan()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
