namespace ExaminationSystem.Models
{
    public class Student : BaseModel
    {
        
        public string Name { get; set; }
        public int Grade { get; set; }
        public DateTime Birthdate { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        
        
        public ICollection<StudentExam> ExamAssignments{ get; set; }
        public ICollection<StudentCourse> StudentCourseEnrollments { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
