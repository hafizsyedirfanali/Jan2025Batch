using MVCDesignPattern.ViewModels;

namespace MVCDesignPattern.Models;

public class FacultyServices
{
    public FacultyServices()
    {
        FacultyViewModel f1 = new()
        {
            Id = 1,
            Name = "Abcd",
            Designation = "Professor",
            Experience = 10.0f
        };
        FacultyViewModel f2 = new()
        {
            Id = 2,
            Name = "Efgh",
            Designation = "Asst. Prof.",
            Experience = 6.0f
        };

        FacultyViewModel f3 = new()
        {
            Id = 3,
            Name = "Ijkl",
            Designation = "Asst. Prof.",
            Experience = 4.0f
        };
        this.Faculties = new() { f1, f2, f3 };
    }
    public List<FacultyViewModel> Faculties { get; set; }
}
