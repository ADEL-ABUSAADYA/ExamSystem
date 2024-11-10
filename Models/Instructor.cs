using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    [Table("Instructor")]
    public class Instructor : BaseModel
    {
        public Instructor() 
        {
            InstructorCourses = new List<InstructorCourse>();
        }
        public string Name { get; set; }
        public string Mobile { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; }

    }
}
