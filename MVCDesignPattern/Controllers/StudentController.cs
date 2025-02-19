using Microsoft.AspNetCore.Mvc;

namespace MVCDesignPattern.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult StudentList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StudentDetails()
        {
            return View();
        }
    }
}
