namespace ExaminationSystem.Models
{
    public class Answer
    {
        public int ID { get; set;}
        public string Body { get; set;}
        public bool IsCorrect { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
    }
}
