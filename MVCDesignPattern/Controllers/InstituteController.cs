using Microsoft.AspNetCore.Mvc;

namespace MVCDesignPattern.Controllers
{
    public class InstituteController : Controller
    {
        [HttpGet]
        public IActionResult AvailableCourses()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CourseDetails()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TopRatedCourses()
        {
            return View();
        }
    }
}
