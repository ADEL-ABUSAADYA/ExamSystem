namespace ExaminationSystem.Models
{
    public class Question : BaseModel
    {
        public string Body { get; set; }
        public int Grade { get; set; }

        public ICollection<ExamQuestion> ExamQuestions { get; set; }

    }
}
