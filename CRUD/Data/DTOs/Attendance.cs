
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Data.DTOs;

public class Attendance
{
    public int Id { get; set; }
    [ForeignKey("Batch")]
    public int BatchId { get; set; }
    [ForeignKey("Student")]
    public int StudentId { get; set; }
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
    public Batch Batch { get; set; } // Navigation Property
    public Student Student { get; set; } // Navigation Property
}
