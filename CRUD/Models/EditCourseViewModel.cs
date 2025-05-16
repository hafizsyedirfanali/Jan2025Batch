using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class EditCourseViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Course Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Duration is required")]
        public string Duration { get; set; }
        [Required(ErrorMessage = "Fees is required")]
        public int Fees { get; set; }
    }
}
