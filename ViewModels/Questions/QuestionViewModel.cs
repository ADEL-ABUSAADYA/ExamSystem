using ExaminationSystem.Models.Enums;
using ExaminationSystem.ViewModels.Answers;


namespace ExaminationSystem.ViewModels.Questions
{
    public class QuestionViewModel
    {
        public int ID { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public QuestionLevel Level { get; set; }
    
        public ICollection<AnswerViewModel> Answers { get; set; }
    }
}
