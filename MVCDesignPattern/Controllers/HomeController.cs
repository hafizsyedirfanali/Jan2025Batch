using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;

namespace MVCDesignPattern.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()//function/method called as action
    {
        ViewBag.Message = "Welcome to MVC Design Pattern";
        ViewBag.Text = "This is a space where you will learn .net";
        ViewData["Date"] = "20-10-2024";
        return View();//default view is index view
    }
    [HttpGet]
    public IActionResult Privacy()
    {
        ViewBag.Message = "Welcome to Privacy view in MVC Design Pattern";
        ViewBag.Text = "This is a space where you will learn .net";
        ViewBag.Date = DateTime.Now;
        return View();//default view is privacy view
    }
    [HttpGet]
    public IActionResult About()
    {
        TempData["Course"] = "We are learning .net";
        TempData["Date"] = DateTime.Now;
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
