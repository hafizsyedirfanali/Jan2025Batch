using CRUD.Data;
using CRUD.Data.DTOs;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers;
/// <summary>
/// CourseController Class is responsible for handling HTTP requests related to courses and 
/// perform required database operations.
/// </summary>
public class CourseController : Controller
{
    //Injecting ApplicationDbContext in the constructor called Dependency Injection
    //Dependency Injection is a design pattern in which a class receives its dependencies from an external source rather than creating them itself.
    //It is injecting the service in the constructor of the class.
    private readonly ApplicationDbContext _dbContext;
    public CourseController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult Courses()
    {
        //Get all the courses from the database
        //and pass it to the view
        var courses = _dbContext.Courses.ToList();
        return View(courses);
    }
    [HttpGet]
    public IActionResult AddCourse()
    {
        //This method will return the view to create a new course
        return View();
    }
    [HttpPost]
    public IActionResult AddCourse(AddCourseViewModel course)
    {
        //This method will add a new course to the database
        if (ModelState.IsValid)
        {
            var entity = new Course
            {
                Name = course.Name,
                Duration = course.Duration,
                Fees = course.Fees,
            };
            _dbContext.Courses.Add(entity);//we did changes in the database context
            _dbContext.SaveChanges();//SaveChanges method is used to save the changes made in the database
            return RedirectToAction("Courses");
        }
        return View(course);
    }
}
