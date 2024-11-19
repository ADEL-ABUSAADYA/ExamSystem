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
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; }

    }
}
