namespace ExaminationSystem.Models
{
    public class Exam : BaseModel
    {
        public int MaxGrade { get; set; }
        public int MaxTime { get; set; }
        public DateTime Date { get; set; }

        public ICollection<ExamQuestion> ExamQuestions { get; set; }
    }
}
