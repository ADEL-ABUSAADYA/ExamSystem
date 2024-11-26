using System.ComponentModel.DataAnnotations;
using ExaminationSystem.Models.Enums;

namespace ExaminationSystem.Models
{
    public class Exam : BaseModel
    {
        public int MaxNumberOfQuestions { get; set; }
        public int MaxTime { get; set; }
        public DateTime Date { get; set; }
        public ExamType ExamType { get; set; }

        public int InstructorId { get; set; }
        public ICollection<ExamQuestions> ExamQuestions { get; set; }
        public ICollection<StudentExams> ExamAssignments { get; set; }
    }
}
