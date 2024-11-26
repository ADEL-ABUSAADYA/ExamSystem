using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Answers;

public class AnswerViewModel
{
    public int ID { get; set;}
    public string Body { get; set;}
    public bool IsCorrect { get; set; }
    public int QuestionID { get; set; }
}
