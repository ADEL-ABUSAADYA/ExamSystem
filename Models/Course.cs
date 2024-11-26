namespace ExaminationSystem.Models
{
    public class Course : BaseModel
    {
        public Course()
        {
            InstructorCourses = new List<InstructorCourses>();
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        public ICollection<InstructorCourses> InstructorCourses { get; set; }
        public ICollection<StudentCourses> StudentCourseEnrollments { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
