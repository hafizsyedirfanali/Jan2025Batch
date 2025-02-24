using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.ViewModels;

namespace MVCDesignPattern.Controllers
{
    public class FacultyController : Controller
    {
        [HttpGet]
        public IActionResult FacultyList()
        {
            FacultyViewModel f1 = new()
            {
                Name = "Abcd",
                Designation = "Professor",
                Experience = 10.0f
            };
            FacultyViewModel f2 = new()
            {
                Name = "Efgh",
                Designation = "Asst. Prof.",
                Experience = 6.0f
            };

            FacultyViewModel f3 = new()
            {
                Name = "Ijkl",
                Designation = "Asst. Prof.",
                Experience = 4.0f
            };

            FacultyViewModel[] model = [f1, f2, f3];//array
            List<FacultyViewModel> model1 = [f1, f2, f3];//list

            return View();
        }
        [HttpGet]
        public IActionResult FacultyDetails()
        {
            FacultyViewModel model = new()
            {
                Name = "Abcd",
                Designation = "Professor",
                Experience = 10.0f
            };
            return View(model);
        }
    }
}
