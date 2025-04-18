using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Data.DTOs;

public class Batch
{
    public int Id { get; set; }
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
}
