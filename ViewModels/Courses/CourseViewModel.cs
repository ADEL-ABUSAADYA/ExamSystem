using ExaminationSystem.ViewModels.Groups;
using ExaminationSystem.ViewModels.Instrucotrs;
using ExaminationSystem.ViewModels.InstructorCourses;
using ExaminationSystem.ViewModels.StudentCourses;

namespace ExaminationSystem.ViewModels.Courses;

public class CourseViewModel 
{
    
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Hours { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
        

    public string InsructorName { get; set; }
    public List<string> StudentsEnrolled { get; set; }
    public List<string> Groups { get; set; }
    
}