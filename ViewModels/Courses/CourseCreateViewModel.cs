namespace ExaminationSystem.ViewModels.Courses;

public class CourseCreateViewModel
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Hours { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}