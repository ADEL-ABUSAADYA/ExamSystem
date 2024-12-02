using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Exams
{
    public class ExamQuestionsViewModel
    {
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
    }
}
