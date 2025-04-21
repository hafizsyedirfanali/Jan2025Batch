using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Data.DTOs;

public class Batch
{
#pragma warning disable
    public int Id { get; set; }
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public Course Course { get; set; }//Navigation Property
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public List<Attendance> Attendances { get; set; }
#pragma warning restore

}
