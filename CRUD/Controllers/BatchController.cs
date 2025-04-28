using CRUD.Data;
using CRUD.Data.DTOs;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers;
/// <summary>
/// 
/// </summary>
public class BatchController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    public BatchController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult Batches()
    {
        ViewBag.Courses = _dbContext.Courses.ToList();
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Batches(int courseId)
    {
        ViewBag.Courses = _dbContext.Courses.ToList();
        var batches = _dbContext.Batches.FirstOrDefault(x => x.CourseId == courseId);
        return View(batches);
    }


    [HttpGet]
    public IActionResult AddCourse()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddCourse(AddCourseViewModel course)
    {
        if (ModelState.IsValid)
        {
            var entity = new Course
            {
                Name = course.Name,
                Duration = course.Duration,
                Fees = course.Fees,
            };
            _dbContext.Courses.Add(entity);
            _dbContext.SaveChanges();
            return RedirectToAction("Courses");
        }
        return View(course);
    }

    [HttpGet]
    public IActionResult EditCourse(int id)
    {
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
            _dbContext.SaveChanges();
            return RedirectToAction("Courses");
        }
        return View(course);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteCourse(int id)
    {
        var entity = _dbContext.Courses.FirstOrDefault(x => x.Id == id);
        if (entity == null)
        {
            return View("Error");
        }
        _dbContext.Courses.Remove(entity);
        _dbContext.SaveChanges();
        return RedirectToAction("Courses");
    }
}
