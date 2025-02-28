using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;
using MVCDesignPattern.ViewModels;

namespace MVCDesignPattern.Controllers
{
    public class FacultyController : Controller
    {
        private readonly FacultyServices facultyServices;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly string uploadFolder;

        public FacultyController(FacultyServices facultyServices, IWebHostEnvironment webHostEnvironment)
        {
            this.facultyServices = facultyServices;
            this.webHostEnvironment = webHostEnvironment;
            this.uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "uploads");
        }
        [HttpGet]
        public IActionResult FacultyList()
        {
            var model = facultyServices.Faculties;

            return View(model);
        }
        [HttpGet]
        public IActionResult EditFaculty(int id)
        {
            var model = facultyServices.Faculties.Find(x => x.Id == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditFaculty(FacultyViewModel model)
        {
            var faculty = facultyServices.Faculties.Find(x => x.Id == model.Id);
            if (faculty is not null)
            {
                faculty.Name = model.Name;
                faculty.Designation = model.Designation;
                faculty.Experience = model.Experience;
            }
            return RedirectToAction("FacultyList");
        }
        [HttpGet]
        public IActionResult UpdateAllFaculties()
        {
            var model = facultyServices.Faculties;

            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateAllFaculties(FacultyViewModel[] model)
        {
            foreach (var item in model)
            {
                var faculty = facultyServices.Faculties.Find(x => x.Id == item.Id);
                if (faculty is not null)
                {
                    faculty.Name = item.Name;
                    faculty.Designation = item.Designation;
                    faculty.Experience = item.Experience;
                }
            }
            return RedirectToAction("FacultyList");
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
            if (model != null)
                facultyServices.Faculties.Remove(model);
            return RedirectToAction("FacultyList");
        }

        [HttpGet]
        public IActionResult UploadPhoto()
        {
            FacultyPhotoViewModel model = new FacultyPhotoViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult UploadPhoto(FacultyPhotoViewModel model)
        {
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }

            if (model.Photo != null && model.Photo.Length > 0)
            {
                var filePath = Path.Combine(uploadFolder, model.Photo.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(stream);
                }
            }

            return RedirectToAction("FacultyList");
        }
    }
}
