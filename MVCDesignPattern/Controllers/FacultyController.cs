using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;
using MVCDesignPattern.ViewModels;

namespace MVCDesignPattern.Controllers
{
    public class FacultyController : Controller
    {
        private readonly FacultyServices facultyServices;

        public FacultyController(FacultyServices facultyServices)
        {
            this.facultyServices = facultyServices;
        }
        [HttpGet]
        public IActionResult FacultyList()
        {
            var model = facultyServices.Faculties;

            return View(model);
        }
        [HttpGet]
        public IActionResult AddFaculty()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFaculty(FacultyViewModel model)
        {
            var faculties = facultyServices.Faculties;//saving the ref(address) of Faculties
            faculties.Add(model);//adding the faculty (model) in the list at ref(address)
            return View(model);
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
