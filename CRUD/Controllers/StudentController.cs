using System.Net;
using CRUD.Data;
using CRUD.Data.DTOs;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers;
/// <summary>
/// StudentController Class is responsible for handling HTTP requests related to students and 
/// perform required database operations.
/// </summary>
public class StudentController : Controller
{
    //Injecting ApplicationDbContext in the constructor called Dependency Injection
    //Dependency Injection is a design pattern in which a class receives its dependencies from an external source rather than creating them itself.
    //It is injecting the service in the constructor of the class.
    private readonly ApplicationDbContext _dbContext;
    public StudentController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult Students()
    {
        var courses = _dbContext.Students.ToList();
        return View(courses);
    }
    [HttpGet]
    public IActionResult AddStudent()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddStudent(AddStudentViewModel model)
    {
        if (ModelState.IsValid)
        {
            var entity = new Student
            {
                Name = model.Name,
                ContactNo = model.ContactNo,
                Email = model.Email,
                Address = model.Address,
                Age = model.Age,
            };
            _dbContext.Students.Add(entity);
            _dbContext.SaveChanges();
            return RedirectToAction("Students");
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult EditStudent(int id)
    {
        var student = _dbContext.Students.AsNoTracking().FirstOrDefault(x => x.Id == id);
        if (student == null)
        {
            return View("Error");
        }
        var model = new EditStudentViewModel
        {
            Id = student.Id,
            Name = student.Name,
            ContactNo = student.ContactNo,
            Email = student.Email,
            Address = student.Address,
            Age = student.Age,
        };
        return View(model);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditStudent(EditStudentViewModel model)
    {
        if (ModelState.IsValid)
        {
            var entity = _dbContext.Students.FirstOrDefault(x => x.Id == model.Id);
            if (entity == null)
            {
                return View("Error");
            }
            entity.Name = model.Name;
            entity.ContactNo = model.ContactNo;
            entity.Email = model.Email;
            entity.Address = model.Address;
            entity.Age = model.Age;

            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Students));
        }
        return View(model);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteStudent(int id)
    {
        var entity = _dbContext.Students.FirstOrDefault(x => x.Id == id);
        if (entity == null)
        {
            return View("Error");
        }
        _dbContext.Students.Remove(entity);
        _dbContext.SaveChanges();
        return RedirectToAction(nameof(Students));
    }
}
