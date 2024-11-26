using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.InstructorCourses;
using ExaminationSystem.ViewModels.StudentCourses;

namespace ExaminationSystem.ViewModels.Students
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }

        public ICollection<StudentCoursesViewModel> StudentCourses { get; set; }
    }
}
