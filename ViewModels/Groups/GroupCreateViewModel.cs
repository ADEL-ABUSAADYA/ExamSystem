using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Students;


namespace ExaminationSystem.ViewModels.Groups
{
    public class GroupCreateViewModel
    {
        public string Name { get; set; }
        public ICollection<StudentViewModel> Students { get; set; } = new List<StudentViewModel>();
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        
    }
    
}
