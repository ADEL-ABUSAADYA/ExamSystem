using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.ExamQuestions
{
    public interface IExamQuestionService
    {
        void Add(ExamQuestionCreateViewModel question);
        void AddRange(IEnumerable<ExamQuestionCreateViewModel> questions);
    }
}
