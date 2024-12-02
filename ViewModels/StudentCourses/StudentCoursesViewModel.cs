using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.StudentCourses;

public class StudentCoursesViewModel
{
    public int ID {get; set;}
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    
}