using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;

namespace MVCDesignPattern.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()//function/method called as action
    {
        return View();//default view is index view
    }
    [HttpGet]
    public IActionResult Privacy()
    {
        return View();//default view is privacy view
    }
    [HttpGet]
    public IActionResult About()
    {
        return View();//default view is privacy view
    }
    [HttpGet]
    public IActionResult Contact()
    {
        return View();//default view is privacy view
    }
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
