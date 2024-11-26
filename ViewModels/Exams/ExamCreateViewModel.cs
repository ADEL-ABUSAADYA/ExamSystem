using ExaminationSystem.Models;
using ExaminationSystem.Models.Enums;

namespace ExaminationSystem.ViewModels.Exams
{
    public class ExamCreateViewModel
    {
        public int MaxNumberOfQuestions { get; set; }
        public int MaxTime { get; set; }
        public DateTime Date { get; set; }
        public ExamType ExamType { get; set; }

        public int InstructorId { get; set; }
        public ICollection<int> QuestionsIDs { get; set; }
    }
}
