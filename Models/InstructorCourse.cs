using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class InstructorCourse
    {
        public int ID { get; set; }

        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        public Instructor Instructor { get; set; }

        public Course Course { get; set; }
    }
}
