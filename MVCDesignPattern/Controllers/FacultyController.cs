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
            //model.Id = faculties.Count + 1;
            model.Id = faculties.Max(x => x.Id) + 1;//select id column and find max and add 1 to it.
            faculties.Add(model);//adding the faculty (model) in the list at ref(address)
            return RedirectToAction("FacultyList");
        }


        [HttpGet]
        //[Route("FacultyList/{id:int}")]
        public IActionResult FacultyDetails([FromRoute] int id)
        {
            var model = facultyServices.Faculties.Find(x => x.Id == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteFaculty([FromRoute] int id)
        {
            var model = facultyServices.Faculties.Find(x => x.Id == id);
            if(model != null)
                facultyServices.Faculties.Remove(model);
            return RedirectToAction("FacultyList");
        }
    }
}
