using ExaminationSystem.ViewModels.Questions;

namespace ExaminationSystem;

public interface IQuestionService
{
    int Add(QuestionCreateViewModel model);
    QuestionViewModel GetQuestionByID(int id);
    bool UpdateQuestion(QuestionEditViewModel model);
    bool DeleteQuestion(int id);
}
