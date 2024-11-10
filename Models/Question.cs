namespace ExaminationSystem.Models
{
    public class Question : BaseModel
    {
        public int Body { get; set; }
        public int Grade { get; set; }

        public ICollection<ExamQuestion> ExamQuestions { get; set; }

    }
}
