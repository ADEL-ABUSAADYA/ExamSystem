using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Courses;
using ExaminationSystem.ViewModels.InstructorCourses;

namespace ExaminationSystem.ViewModels.Instrucotrs
{
    public class InstructorViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }

        public List<string> InstructorCourses { get; set; }
    }
}
