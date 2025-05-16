using CRUD.Data;
using CRUD.Data.DTOs;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        var courses = _dbContext.Courses.ToList();//READ
        //above line will get translated by Entity Framework Core to SQL query  "select * from Courses"
        return View(courses);
    }
    [HttpGet]
    public IActionResult AddCourse()
    {
        //This method will return the view to create a new course
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
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
            _dbContext.Courses.Add(entity);//we did changes in the database context //CREATE
            _dbContext.SaveChanges();//SaveChanges method is used to save the changes made in the database
            //this will be translated as insert query
            return RedirectToAction("Courses");
        }
        return View(course);
    }

    [HttpGet]
    public IActionResult EditCourse(int id)
    {
        //This method will return the view to edit a course
        var course = _dbContext.Courses.AsNoTracking().FirstOrDefault(x => x.Id == id);
        if (course == null)
        {
            return View("Error");
        }
        var model = new EditCourseViewModel
        {
            Id = course.Id,
            Name = course.Name,
            Duration = course.Duration,
            Fees = course.Fees,
        };
        return View(model);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditCourse(EditCourseViewModel course)
    {
        //This method will update the course in the database
        if (ModelState.IsValid)
        {
            var entity = _dbContext.Courses.FirstOrDefault(x => x.Id == course.Id);
            if (entity == null)
            {
                return View("Error");
            }
            entity.Name = course.Name;
            entity.Duration = course.Duration;
            entity.Fees = course.Fees;
            _dbContext.SaveChanges();//UPDATE
            //above line will get translated by Entity Framework Core to SQL query  "update Courses set Name = course.Name, Duration = course.Duration, Fees = course.Fees where Id = course.Id"
            //Advantage of Entity framework.
            //if only one record is updated then it will not update the other records.
            return RedirectToAction("Courses");
        }
        return View(course);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteCourse(int id)
    {
        //This method will delete the course from the database
        var entity = _dbContext.Courses.FirstOrDefault(x => x.Id == id);
        if (entity == null)
        {
            return View("Error");
        }
        _dbContext.Courses.Remove(entity);//DELETE
        _dbContext.SaveChanges();
        //this will be translated as delete query, delete from Courses where Id = id
        return RedirectToAction("Courses");
    }
}
