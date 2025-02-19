using Microsoft.AspNetCore.Mvc;

namespace MVCDesignPattern.Controllers
{
    public class FacultyController : Controller
    {
        [HttpGet]
        public IActionResult FacultyList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FacultyDetails()
        {
            return View();
        }
    }
}
