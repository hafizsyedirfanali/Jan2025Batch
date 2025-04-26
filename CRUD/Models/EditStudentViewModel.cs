using System.ComponentModel.DataAnnotations;
using CRUD.Data.DTOs;

namespace CRUD.Models;

public class EditStudentViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Display(Name = "Contact Number")]
    public string ContactNo { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public string? Address { get; set; }
    [Range(18, 50, ErrorMessage = "Age must be between 18 and 50.")]
    public byte Age { get; set; }
}
